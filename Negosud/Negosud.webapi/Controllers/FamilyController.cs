using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Negosud.dataaccess;
using Negosud.dataaccess.Tables;

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("families")]
    public class FamilyController : ControllerBase
    {
        /**
         * Retourne une liste de familles
         * 
         * @returns Liste de familles
         */
        [HttpGet]
        public IEnumerable<FamilyDTO> GetAll()
        {
            using (NegosudContext context = new NegosudContext())
            {
                return context.Families.ToList().Select(f => convert(f)).ToList();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<FamilyDTO> GetById(int id)
        {
            using (NegosudContext context = new NegosudContext())
            {
                Family? family = context.Families.FirstOrDefault(f => f.Id == id);
                FamilyDTO familyDTO = convert(family);
                return familyDTO != null ? Ok(familyDTO) : NotFound();
            }
        }

        private FamilyDTO convert(Family family)
        {
            FamilyDTO familyDTO = new FamilyDTO();
            familyDTO.Id = family.Id;
            familyDTO.Name = family.Name;

            return familyDTO;
        }

        [HttpPost]
        public IActionResult Post([FromBody] FamilyDTO familyDTO)
        {
            using (NegosudContext context = new NegosudContext())
            {
                Family familyResult = new Family();

                familyResult.Name = familyDTO.Name;

                context.Families.Add(familyResult);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
