using Microsoft.AspNetCore.Mvc;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("Items")]
    public class ItemController : Controller
    {


        [HttpPost]
        public IActionResult Post([FromBody] ItemDTO itemDTO)
        {
            using (NegosudContext context = new NegosudContext())
            {
                Item itemResult = new Item();

                itemResult.Name = itemDTO.Name;
                itemResult.Description = itemDTO.Description;
                itemResult.Family = context.Families.Where(i => i.Id == itemDTO.Family).Single();



                context.Items.Add(itemResult);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}

