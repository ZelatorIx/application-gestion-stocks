using Microsoft.AspNetCore.Mvc;
using Negosud.MVCWeb.Models;
using Negosud.MVCWeb.Types;
using Negosud.webapi.Models;

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
			List<ItemDTO> items = await model.GetItems();
			List<FamilyDTO> families = await model.GetFamilies();

			return View(new { items, families });
        }

		public async Task<IActionResult> Details(int id)
		{
            ItemDTO? item = await model.GetItemById(id);

            return View(item);
        }

		public async Task<IActionResult> Search([FromForm] string form)
		{
			List<ItemDTO> allItems = await model.GetItems();
			List<FamilyDTO> allFamilies = await model.GetFamilies();

            int familyId = 0;
			string research = "";

			List<ItemDTO> items = allItems
				.Where((ItemDTO item, int index) => item.Family.Id == familyId)
				.Where((ItemDTO item, int index) => allItems[index].Name.Contains(research))
				.ToList();

            return View(new { items, families = allFamilies });
		}
	}
}
