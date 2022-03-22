using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Web;
using BusinessDirectory.Server.Repositories;
using BusinessDirectory.MailClient;
using BusinessDirectory.Helpers;

namespace BusinessDirectory.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var isValidOtp = await ValidateOTP(request.OTPValidate);
            if (isValidOtp.Success)
            {
                var response = await _authRepo.Register(
                new User
                {
                    FirstName = request.FirstName,
                    LastName = string.IsNullOrEmpty(request.LastName) ? string.Empty : request.LastName,
                    EmailAddress = request.Email,
                    MobileNumber = 0,
                    AddressID = 0,
                    IsActive = false,
                    UserTimestamp = DateTime.UtcNow,
                    UpdateTimestamp = DateTime.UtcNow,
                    UpdatedBy = 0,
                    IsVoter = false,
                    IsCandidate = false,
                    numberOfVotes = 0
                });
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            else
            {
                return BadRequest(isValidOtp);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var isValidOtp = await ValidateOTP(request.OTPValidate);
            if (isValidOtp.Success)
            {
                var response = await _authRepo.Login(request.Email);
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            else
            {
                return BadRequest(isValidOtp);
            }

        }

        [HttpPost("getotp")]
        public async Task<IActionResult> GetOTP(UserLogin user)
        {
            var response = new ServiceResponse<string>();

            var emailClient = new EmailClient();
            var otp = emailClient.GenerateOTP();
            var encryptedOtp = EncryptionHelper.Encrypt($"{otp}${DateTime.UtcNow.ToString("yyyyMMddHHmmss")}");
            bool emailSuccess = emailClient.SendEmail(user.Email, "businessdirectory.team3@gmail.com", "team3@123", "Election Commission");

            if (!emailSuccess)
            {
                response.Success = false;
                response.Message = "Unable to send OTP via mail.";
                return BadRequest(response);
            }

            response.Data = encryptedOtp;
            response.Message = "OTP sent successfully via mail.";
            return Ok(response);
        }

        public async Task<ServiceResponse<string>> ValidateOTP(OTPValidate otpValidate)
        {
            var response = new ServiceResponse<string>();

            var decryptedOtpTime = EncryptionHelper.Decrypt(HttpUtility.UrlDecode(otpValidate.EncryptedActualOTPTimestamp.Trim('"')));
            var prevDate = DateTime.ParseExact(decryptedOtpTime.Split('$')[1], "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            var currentDate = DateTime.UtcNow;
            var timespan = currentDate.Subtract(prevDate);
            if (timespan.Minutes > 2 || !otpValidate.UserOTP.Equals(decryptedOtpTime.Split('$')[0]))
            {
                response.Success = false;
                response.Message = "Invalid OTP";
                return response;
            }

            response.Message = "Valid OTP";
            return response;
        }
    }
}
