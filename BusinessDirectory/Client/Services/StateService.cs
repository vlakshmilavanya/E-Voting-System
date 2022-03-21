using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using System.Net.Http;
using System.Net.Http.Json;

namespace BusinessDirectory.Client.Services
{
    public class StateService : IStateService
    {
        private readonly HttpClient _httpClient;

        public StateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
       

        public async Task<State> addProfileState(ProfileModel model)
        {
            var response = await _httpClient.PostAsJsonAsync<ProfileModel>("api/State/Profile", model);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<State>();
            }
            else
                return null;
        }

        public async Task<State> getStateById(int Id)
        {
            return await _httpClient.GetFromJsonAsync<State>($"api/State/{Id}");
        }

        public async Task<State> getStateByName(string name)
        {
            return await _httpClient.GetFromJsonAsync<State>($"api/State/{name}");

        }

    }
}
