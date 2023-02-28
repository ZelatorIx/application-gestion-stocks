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

		[Route("Item")]
        public async Task<ViewResult> Index()
		{
			List<Item> items = await model.GetItems();

			return View(items);
        }

        [Route("Item/{id}")]
		public async Task<ViewResult> Details(int id)
		{
            Item? item = await model.GetItemById(id);

            return View(item);
        }
	}
}
