using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using System.Net.Http.Json;

namespace BusinessDirectory.Client.Services
{
    public class VotingService : IVoting
    {
        private readonly HttpClient _httpClient;

        public VotingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Roles>> GetRolesByRole(int id)
        {
            return await _httpClient.GetFromJsonAsync<List<Roles>>($"/api/Voting/{id}");
        }

        public async Task<bool> CheckId(int id)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"/api/Voting/Id/{id}");
        }

        public async Task<Vote> AddRole(VoteModel model)
        {
            var response = await _httpClient.PostAsJsonAsync<VoteModel>("api/Voting", model);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Vote>();
            }
            return null;
        }
    }
}
