using Microsoft.AspNetCore.Mvc;
using Negosud.MVCWeb.Data;
using Negosud.MVCWeb.Services.Model;
using Negosud.MVCWeb.Types;

namespace Negosud.MVCWeb.Controllers
{
    public class BasketController : Controller
    {
        private Dictionary<int, BasketItem> items;

        public BasketController()
        {
            items = new Dictionary<int, BasketItem>();
        }

        public IActionResult Index()
        {
            return View(items);
        }

        public RedirectToActionResult Add(int id, string name)
        {
            if (!items.ContainsKey(id))
            {
                items.Add(id, new BasketItem() { Name = name });
            }

            items[id].Quantity++;

            return RedirectToAction("Index", "Item");
        }
    }
}
