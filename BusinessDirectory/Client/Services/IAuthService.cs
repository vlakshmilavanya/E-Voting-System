using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request, UserOTP userOTP);
        Task<ServiceResponse<string>> Login(UserLogin request, UserOTP userOTP);
        Task<ServiceResponse<string>> GetOTP(UserLogin user);
    }
}
