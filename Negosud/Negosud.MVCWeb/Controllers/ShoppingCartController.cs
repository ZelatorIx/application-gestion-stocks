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

        /// <summary>
        /// Affiche la page principale du panier
        /// </summary>
        /// <returns>Page principale</returns>
        public IActionResult Index()
        {
            return View(GetShoppingCart());
        }

        /// <summary>
        /// Ajoute un article dans le panier
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <param name="name">Nom de l'article</param>
        /// <param name="redirect">Indique s'il doit y avoir une redirection vers la page des articles</param>
        /// <returns>Retourne à la page principale</returns>
        public RedirectToActionResult Add(int id, string name, bool? redirect)
        {
            Dictionary<int, ShoppingCart> items = GetShoppingCart();

            if (!items.ContainsKey(id))
            {
                items.Add(id, new ShoppingCart() { Name = name, Quantity = 0 });
            }

            items[id].Quantity++;
            SaveShoopingCart(items);

            if (redirect == true)
            {
                return RedirectToAction("Index", "Item");
            } else
            {
                return RedirectToAction("Index");
            }
        }

        /// <summary>
        /// Retire un article du panier
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <param name="name">Nom de l'article</param>
        /// <returns>Retourne à la page principale</returns>
        public RedirectToActionResult Minus(int id, string name)
        {
            Dictionary<int, ShoppingCart> items = GetShoppingCart();

            if (!items.ContainsKey(id))
            {
                return RedirectToAction("Index");
            }

            if (items[id].Quantity > 1)
            {
                items[id].Quantity--;
            }
            else
            {
                return Delete(id);
            }

            SaveShoopingCart(items);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Supprime un article du panier
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <returns>Retourne à la page principale</returns>
        public RedirectToActionResult Delete(int id)
        {
            Dictionary<int, ShoppingCart> items = GetShoppingCart();

            if (!items.ContainsKey(id))
            {
                return RedirectToAction("Index");
            }

            items.Remove(id);
            SaveShoopingCart(items);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Supprime le panier
        /// </summary>
        /// <param name="actualize">Indique que la page ne doit pas être actualisée</param>
        private void DeleteShoppingCart(bool actualize = false)
        {
            string? cookie = Request.Cookies[SHOPPING_CART_COOKIE];

            if (cookie != null)
            {
                HttpContext.Response.Cookies.Delete(SHOPPING_CART_COOKIE);
            }
        }

        /// <summary>
        /// Supprime le panier
        /// </summary>
        /// <returns>Retourne à la page principale</returns>
        public RedirectToActionResult DeleteShoppingCart()
        {
            DeleteShoppingCart(false);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Sauvegarde le panier d'articles
        /// </summary>
        /// <param name="data">Panier d'articles</param>
        private RedirectToActionResult SaveShoopingCart(Dictionary<int, ShoppingCart> data)
        {
            DeleteShoppingCart(false);
            string stringCookie = JsonConvert.SerializeObject(data);
            HttpContext.Response.Cookies.Append(SHOPPING_CART_COOKIE, stringCookie);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Récupère le panier d'articles
        /// </summary>
        /// <returns>Retourne à la page des articles</returns>
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

        public RedirectToActionResult Command()
        {
            DeleteShoppingCart(false);

            return RedirectToAction("Index", "Item");
        }
    }
}
