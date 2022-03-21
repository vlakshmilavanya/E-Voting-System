using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using System.Net.Http.Json;

namespace BusinessDirectory.Client.Services
{
    public class RolesService : IRoles
    {
        private readonly HttpClient _httpClient;

        public RolesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Roles>> GetAllRoles()
        {
            return await _httpClient.GetFromJsonAsync<List<Roles>>("/api/Roles/all");
        }

        public async Task<List<RoleType>> GetAllRoleTypes()
        {
            return await _httpClient.GetFromJsonAsync<List<RoleType>>("/api/Roles/roletypes");
        }

        public async Task<Roles> UpdateRole(RolesModel model)
        {
            var response = await _httpClient.PutAsJsonAsync<RolesModel>($"/api/Roles/{model.RoleID}", model);
            return await response.Content.ReadFromJsonAsync<Roles>();
        }

        public async Task DeleteRole(RolesModel model)
        {
            await _httpClient.DeleteAsync($"/api/Roles/{model.RoleID}");
        }

        public async Task<Roles> AddRole(RolesModel model)
        {
            var response = await _httpClient.PostAsJsonAsync<RolesModel>("api/Roles", model);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Roles>();
            }
            return null;
        }

        public async Task<Roles> GetRoleById(int id)
        {
            var service = await _httpClient.GetFromJsonAsync<Roles>($"/api/Roles/{id}");
            return service;
        }

        public async Task<List<Roles>> GetRoleByUserId(int id)
        {
            return await _httpClient.GetFromJsonAsync<List<Roles>>($"/api/Roles/User/{id}");
        }
    }
}
