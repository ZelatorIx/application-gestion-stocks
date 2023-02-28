using Microsoft.AspNetCore.Mvc;
using Negosud.MVCWeb.Services.Model;
using Negosud.MVCWeb.Types;

namespace Negosud.MVCWeb.Controllers
{
    public class ItemController : Controller
	{
		private readonly Model model;

		public ItemController(Model model)
		{
			this.model = model;
		}

		public async Task<ViewResult> Index()
		{
			List<Item> items = await GetItems();

            return View(items);
		}

		private async Task<List<Item>> GetItems()
		{
			return await model.GetItems();
		}
	}
}
