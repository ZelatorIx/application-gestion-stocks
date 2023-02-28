using Microsoft.AspNetCore.Mvc;

namespace Negosud.MVCWeb.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
