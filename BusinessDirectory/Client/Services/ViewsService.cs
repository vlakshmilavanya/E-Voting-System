using BusinessDirectory.DB.Models;
using System.Net.Http.Json;
using BusinessDirectory.ViewModels;

namespace BusinessDirectory.Client.Services
{
    public class ViewsService : IViews
    {
        private readonly HttpClient httpClient;

        public ViewsService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ShareYourViews> AddView(ShareViewsModel viewsModel)
        {
            var response = await httpClient.PostAsJsonAsync<ShareViewsModel>("api/ShareViews", viewsModel);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ShareYourViews>();
            }
            else
                return null;
        }

        public async Task<ShareYourViews> GetViewById(int viewId)
        {
            var view = await httpClient.GetFromJsonAsync<ShareYourViews>($"/api/ShareViews/{viewId}");
            return view;
        }


        public async Task<List<ShareYourViews>> GetViews()
        {
            return await httpClient.GetFromJsonAsync<List<ShareYourViews>>("/api/ShareViews/all");
        }

    }
}
