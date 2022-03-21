using BusinessDirectory.Data;
using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
using System.Net.Http;
using System.Net.Http.Json;

namespace BusinessDirectory.Client.Services
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
       

        public async Task<Address> addAddress(ProfileModel model)
        {
            Address address = new Address()
            {
                Building = model.Building,
                Street = model.Street,
                City = model.City,
                Pincode = model.Pincode,
                StateId = model.StateId,
                Landmark = model.Landmark,
                Area = model.Area,
                CountryId = 1,
                AddressTimestamp = DateTime.Now,
                UpdateDate = DateTime.Now

            };
            var response = await _httpClient.PostAsJsonAsync<Address>("api/Address", address);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Address>();
            }
            else
                return null;
        }
        public async Task<Address> getAddressById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Address>($"api/Address/{id}");
        }

       

        public async Task<List<CityModel>> GetCities()
        {
            var response = await _httpClient.GetFromJsonAsync<List<CityModel>>("api/Address/cities");
            return response;
        }
    }
}
