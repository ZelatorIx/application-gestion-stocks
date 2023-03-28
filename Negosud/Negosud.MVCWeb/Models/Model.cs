using Negosud.dataaccess.Tables;
using Negosud.MVCWeb.Data;
using Negosud.MVCWeb.Services;
using Negosud.MVCWeb.Types;
using Negosud.webapi.Models;

namespace Negosud.MVCWeb.Models
{
    public class Model
    {
        private RESTAPIService api;

        public Model(RESTAPIService api)
        {
            this.api = api;
        }

        public async Task<List<FamilyDTO>> GetFamilies()
        {
            return await api.Get<List<FamilyDTO>>("families") ?? new List<FamilyDTO>();
        }

        public async Task<List<ItemDTO>> GetItems()
        {
            return await api.Get<List<ItemDTO>>("items") ?? new List<ItemDTO>();
        }

        public async Task<ItemDTO> GetItemById(int id)
        {
            return await api.Get<ItemDTO>($"items/{id}");
        }

        public async Task<CustomerDTO> GetCustomerById(int id)
        {
            return await api.Get<CustomerDTO>($"customers/{id}");
        }

        public async Task<CommandCustomerDTO> GetCommandCustomerById(int id)
        {
            return await api.Get<CommandCustomerDTO>($"commands-customer/{id}");
        }

        public async Task<string> CreateCommand(CommandCustomerDTO commandCustomer, KeyValuePair<int, ShoppingCart> shoppingCart)
        {
            ItemDTO item = await GetItemById(shoppingCart.Key);

            await api.Post<CommandCustomerDTO>("commands-customer", commandCustomer);

            CustomerOrderContentDTO customerOrderContent = new CustomerOrderContentDTO()
            {
                Quantity = shoppingCart.Value.Quantity,
                BeforePriceTax = item.SellingPriceBT,
                Vat = item.Vat,
                Item = item,
                CommandCustomer = commandCustomer
            };

            await api.Post<CustomerOrderContentDTO>("commands-order-content", customerOrderContent);

            return "";
        }
    }
}
