using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public interface IUser
    {
        Task<List<User>> GetUsers();
        //Task<User> GetUser(int userId);
        Task<User> UpdateUser(ProfileModel profileModel);
        Task<User> GetUser(int userId);
        Task<User> GetUserByEmail(string email);
        Task<User> AddUser(User user);
        //Task<User> UpdateUser(ProfileModel profileModel);
    }
}
