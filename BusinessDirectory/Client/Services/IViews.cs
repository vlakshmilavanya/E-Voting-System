using BusinessDirectory.DB.Models;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public interface IViews
    {
        Task<ShareYourViews> AddView(ShareViewsModel viewsModel);
        Task<List<ShareYourViews>> GetViews();
        Task<ShareYourViews> GetViewById(int viewId);
    }
}
