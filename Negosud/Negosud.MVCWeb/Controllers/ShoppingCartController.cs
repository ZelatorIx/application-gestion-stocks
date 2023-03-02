using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Negosud.MVCWeb.Data;
using Negosud.MVCWeb.Types;
using Newtonsoft.Json;
using System.Net;

namespace Negosud.MVCWeb.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly string SHOPPING_CART_COOKIE;

        public ShoppingCartController()
        {
            SHOPPING_CART_COOKIE = "shopping_cart";
        }

        public IActionResult Index()
        {
            return View(GetShoppingCart());
        }

        /// <summary>
        /// Ajouter un article dans le panier
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <param name="name">Nom de l'article</param>
        /// <returns>Redirection de la vue</returns>
        public RedirectToActionResult Add(int id, string name)
        {
            Dictionary<int, ShoppingCart> items = GetShoppingCart();

            if (!items.ContainsKey(id))
            {
                items.Add(id, new ShoppingCart() { Name = name, Quantity = 0 });
            }

            items[id].Quantity++;

            SaveShoopingCart(items);
            return RedirectToAction("Index", "Item");
        }

        public void Minus(int id, string name)
        {
            Dictionary<int, ShoppingCart> items = GetShoppingCart();

            if (!items.ContainsKey(id))
            {
                return;
            }

            if (items[id].Quantity > 1)
            {
                items[id].Quantity--;
            } else
            {
                Delete(id);
            }
        }

        public void Delete(int id)
        {
            Dictionary<int, ShoppingCart> items = GetShoppingCart();

            if (!items.ContainsKey(id))
            {
                return;
            }

            items.Remove(id);
        }

        public void DeleteShoppingCart()
        {
            string? cookie = Request.Cookies[SHOPPING_CART_COOKIE];

            if (cookie != null)
            {
                HttpContext.Response.Cookies.Delete(SHOPPING_CART_COOKIE);
            }
        }

        /// <summary>
        /// Sauvegarde le panier d'articles
        /// </summary>
        /// <param name="data">Panier d'articles</param>
        private void SaveShoopingCart(Dictionary<int, ShoppingCart> data)
        {
            DeleteShoppingCart();
            string stringCookie = JsonConvert.SerializeObject(data);
            HttpContext.Response.Cookies.Append(SHOPPING_CART_COOKIE, stringCookie);
        }

        /// <summary>
        /// Retourne le panier d'articles
        /// </summary>
        /// <returns>Panier des articles</returns>
        private Dictionary<int, ShoppingCart> GetShoppingCart()
        {
            string? cookie = Request.Cookies[SHOPPING_CART_COOKIE];
            Dictionary<int, ShoppingCart>? shoppingCart = null;

            if (cookie != null)
            {
                shoppingCart = JsonConvert.DeserializeObject<Dictionary<int, ShoppingCart>>(cookie);
            }

            return shoppingCart ?? new Dictionary<int, ShoppingCart>();
        }
    }
}
