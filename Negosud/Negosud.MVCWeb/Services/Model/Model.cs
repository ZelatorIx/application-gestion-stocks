using Negosud.MVCWeb.Types;

namespace Negosud.MVCWeb.Services.Model
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
    }
}
