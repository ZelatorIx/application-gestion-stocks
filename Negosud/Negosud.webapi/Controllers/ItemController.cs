using Microsoft.AspNetCore.Mvc;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : Microsoft.AspNetCore.Mvc.Controller
    {


        [HttpPost]
        public IActionResult Post([FromBody] ItemDTO itemDTO)
        {
            using (NegosudContext context = new NegosudContext())
            {
                ItemDTO itemResult = new ItemDTO();

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

