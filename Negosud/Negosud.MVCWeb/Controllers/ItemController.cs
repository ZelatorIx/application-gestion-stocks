using Microsoft.AspNetCore.Mvc;

namespace Negosud.MVCWeb.Controllers
{
	public class ItemController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.toto = "toto";
			return View();
		}
	}
}
