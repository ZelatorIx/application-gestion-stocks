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
                return context.Families.ToList().Select(f => Convert(f)).ToList();
            }
        }

        /**
         * Retourne une famille par son identifiant
         * 
         * @param id Identifiant de la famille
         * @returns Famille
         */
        [HttpGet("{id}")]
        public ActionResult<FamilyDTO> GetById(int id)
        {
            using (NegosudContext context = new NegosudContext())
            {
                Family? family = context.Families.FirstOrDefault(f => f.Id == id);
                FamilyDTO familyDTO = Convert(family);
                return familyDTO != null ? Ok(familyDTO) : NotFound();
            }
        }

        /**
         * Convertie une Family en FamilyDTO
         * 
         * @param family Famille à caster
         * @returns Famille castée en DTO
         */
        private FamilyDTO Convert(Family? family)
        {
            FamilyDTO familyDTO = new FamilyDTO();

            if (family != null)
            {
                familyDTO.Id = family.Id;
                familyDTO.Name = family.Name;
            }

            return familyDTO;
        }

        /**
         * Crée une famille
         * 
         * @param familyDTO Famille à créer
         * @returns Résultat de la requête
         */
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
