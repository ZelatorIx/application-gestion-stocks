using Microsoft.AspNetCore.Mvc;
using Negosud.MVCWeb.Models;
using Negosud.MVCWeb.Types;

namespace Negosud.MVCWeb.Controllers
{
    public class ItemController : Controller
	{
		private readonly Model model;

        public ItemController(Model model, ShoppingCartController basket)
		{
			this.model = model;
		}

        public async Task<IActionResult> Index()
		{
			List<Item> items = await model.GetItems();
			List<Family> families = await model.GetFamilies();

			return View(new { items, families });
        }

		public async Task<IActionResult> Details(int id)
		{
            Item? item = await model.GetItemById(id);

            return View(item);
        }

		public async Task<IActionResult> Search([FromForm] string form)
		{
			List<Item> allItems = await model.GetItems();
			List<Family> allFamilies = await model.GetFamilies();

            int familyId = 0;
			string research = "";

			List<Item> items = allItems
				.Where((Item item, int index) => item.FamilyId == familyId)
				.Where((Item item, int index) => allItems[index].Name.Contains(research))
				.ToList();

            return View(new { items, families = allFamilies });
		}
	}
}
