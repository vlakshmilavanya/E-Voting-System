using BusinessDirectory.DB.Models;
using System.Net.Http.Json;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public class UserService : IUser
    {
        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<User> AddUser(User user)
        {
            var response = await httpClient.PostAsJsonAsync<User>("/api/users", user);
            return await response.Content.ReadFromJsonAsync<User>();
        }

        public async Task<User> GetUser(int userId)
        {
            var user = await httpClient.GetFromJsonAsync<User>($"/api/users/{userId}");
            return user;
        }
        
        
        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsers()
        {
            return await httpClient.GetFromJsonAsync<List<User>>("/api/users/all");
        }


        public async Task<User> UpdateUser(ProfileModel profileModel)
        {
            var response = await httpClient.PutAsJsonAsync<ProfileModel>($"/api/users/{profileModel.UserId}", profileModel);
            return await response.Content.ReadFromJsonAsync<User>();
        }
    }
}
