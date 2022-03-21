using BusinessDirectory.ViewModels;
using BusinessDirectory.DB.Models;

namespace BusinessDirectory.Client.Services
{
    public interface IVoting
    {
        Task<List<Roles>> GetRolesByRole(int id);
        Task<Vote> AddRole(VoteModel model);
        Task<bool> CheckId(int id);
    }
}
