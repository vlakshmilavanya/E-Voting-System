using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public interface IAddressService
    {
        Task<Address> addAddress(ProfileModel model);
        Task<Address> getAddressById(int id);

        Task<List<CityModel>> GetCities();
    }
}
