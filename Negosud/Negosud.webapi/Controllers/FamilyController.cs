using Microsoft.AspNetCore.Mvc;
using Negosud.dataaccess;
using Negosud.dataaccess.Tables;

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("families")]
    public class FamilyController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Family> GetAll()
        {
            using (NegosudContext context = new NegosudContext())
            {
                return context.Families.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using (NegosudContext context = new NegosudContext())
            {
                Family? family = context.Families.FirstOrDefault(f => f.Id == id);

                return family != null ? Ok(family) : NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Family family)
        {
            using (NegosudContext context = new NegosudContext())
            {
                context.Families.Add(family);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
