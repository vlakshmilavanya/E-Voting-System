using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public interface IStateService
    {
        Task<State> getStateByName(string name);
        Task<State> getStateById(int Id);

        Task<State> addProfileState(ProfileModel model);
    }
}
