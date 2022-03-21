using BusinessDirectory.ViewModels;
using BusinessDirectory.DB.Models;

namespace BusinessDirectory.Client.Services
{
    public interface IRoles
    {
        Task<List<Roles>> GetAllRoles();
        Task<List<RoleType>> GetAllRoleTypes();
        Task<Roles> UpdateRole(RolesModel model);
        Task DeleteRole(RolesModel model);
        Task<Roles> AddRole(RolesModel model);
        Task<Roles> GetRoleById(int id);
        Task<List<Roles>> GetRoleByUserId(int id);
    }
}
