using Blazored.LocalStorage;
using BusinessDirectory.ViewModels;
using System.Net.Http.Json;

namespace BusinessDirectory.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorageService;

        public AuthService(HttpClient http, ILocalStorageService localStorageService)
        {
            _http = http;
            _localStorageService = localStorageService;
        }

        public async Task<ServiceResponse<string>> GetOTP(UserLogin user)
        {
            var result = await _http.PostAsJsonAsync("api/auth/getotp", user);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request, UserOTP userOTP)
        {
            string otpInStorage = await _localStorageService.GetItemAsStringAsync("OTP");
            request.OTPValidate = new OTPValidate
            {
                EncryptedActualOTPTimestamp = otpInStorage,
                UserOTP = userOTP.OTP
            };
            var result = await _http.PostAsJsonAsync("api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request, UserOTP userOTP)
        {
            string otpInStorage = await _localStorageService.GetItemAsStringAsync("OTP");

            request.OTPValidate = new OTPValidate
            {
                EncryptedActualOTPTimestamp = otpInStorage,
                UserOTP = userOTP.OTP
            };
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();

        }
    }
}
