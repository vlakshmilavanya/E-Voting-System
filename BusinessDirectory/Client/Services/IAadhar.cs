using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;
namespace BusinessDirectory.Client.Services
{
    public interface IAadhar
    {
        Task<AadharAuth> GetAadharDetails(string name);
        Task<bool> GetAadharByNumber(string name);
        Task<AadharAuth> UpdateAadhar(AadharModel aadharModel);

    }
}
