using BusinessDirectory.DB.Models;
using System.Net.Http.Json;
using BusinessDirectory.ViewModels;
namespace BusinessDirectory.Client.Services
{
    public class AadharService : IAadhar
    {
        private readonly HttpClient httpClient;

        public AadharService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<AadharAuth> GetAadharDetails(string name)
        {
            var aadhar = await httpClient.GetFromJsonAsync<AadharAuth>($"/api/Aadhar/{name}");
            return aadhar;
        }

        public async Task<bool> GetAadharByNumber(string name)
        {
            return await httpClient.GetFromJsonAsync<bool>($"/api/Aadhar/Number/{name}");
        }

        public async Task<AadharAuth> UpdateAadhar(AadharModel aadharModel)
        {
            var response = await httpClient.PutAsJsonAsync<AadharModel>($"/api/Aadhar/{aadharModel.AadharId}", aadharModel);
            return await response.Content.ReadFromJsonAsync<AadharAuth>();
        }


    }
}
