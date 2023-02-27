using Negosud.MVCWeb.Services.Model.Types;

namespace Negosud.MVCWeb.Services.Model
{
    public class Model
    {
        private RESTAPIService api;

        public Model(RESTAPIService api)
        {
            this.api = api;
        }

        public async Task<List<ModelFamily>> GetFamilies()
        {
            return await api.Get<List<ModelFamily>>("families");
        }

        public async Task<List<ModelItem>> GetItems()
        {
            return await api.Get<List<ModelItem>>("items");
        }
    }
}
