using Negosud.MVCWeb.Services;
using Negosud.MVCWeb.Types;

namespace Negosud.MVCWeb.Models
{
    public class Model
    {
        private RESTAPIService api;

        public Model(RESTAPIService api)
        {
            this.api = api;
        }

        public async Task<List<Family>> GetFamilies()
        {
            return await api.Get<List<Family>>("families") ?? new List<Family>();
        }

        public async Task<List<Item>> GetItems()
        {
            return await api.Get<List<Item>>("items") ?? new List<Item>();
        }

        public async Task<Item> GetItemById(int id)
        {
            return await api.Get<Item>($"items/{id}");
        }
    }
}
