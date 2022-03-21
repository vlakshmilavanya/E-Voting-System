using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Server.Repositories
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user);
        Task<ServiceResponse<string>> Login(string email);
        Task<bool> UserExists(string email);
    }
}
