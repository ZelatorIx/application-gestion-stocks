using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess;
using Negosud.dataaccess.Tables;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("families")]
    public class FamilyController : ControllerBase
    {
        private readonly NegosudContext _context;

        public FamilyController(NegosudContext context)
        {
            _context = context;
        }

        /**
         * Retourne une liste de familles
         * 
         * @returns Liste de familles
         */
        [HttpGet]
        public async Task<List<FamilyDTO>> GetAll()
        {
            return await _context.Families
                .Select((Family family) => ConvertToFamilyDTO(family))
                .ToListAsync();
        }

        /**
         * Retourne une famille par son identifiant
         * 
         * @param id Identifiant de la famille
         * @return Famille
         */
        [HttpGet("{id}")]
        public async Task<ActionResult<FamilyDTO>> GetById(int id)
        {
            Family? family = await _context.Families.FindAsync(id);

            if (family == null)
            {
                return NotFound();
            }

            return Ok(ConvertToFamilyDTO(family));
        }

        /**
         * Crée une famille
         * 
         * @param familyDTO Famille à créer
         * @return Etat de la requête
         */
        [HttpPost]
        public async Task<ActionResult<FamilyDTO>> Post([FromBody] FamilyDTO familyDTO)
        {
            Family familyResult = new Family() { Name = familyDTO.Name };

            _context.Families.Add(familyResult);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetById),
                new { id = familyDTO.Id },
                ConvertToFamilyDTO(familyResult)
            );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] FamilyDTO familyDTO)
        {
            if (id != familyDTO.Id)
            {
                return BadRequest();
            }

            Family? family = await _context.Families.FindAsync(id);
            if (family == null)
            {
                return NotFound();
            }

            family.Name = familyDTO.Name;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!FamilyExist(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Family? family = await _context.Families.FindAsync(id);
            if (family == null)
            {
                return NotFound();
            }

            if (family.Items != null && family.Items.Length > 0)
            {
                return Forbid();
            }

            _context.Families.Remove(family);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FamilyExist(long id)
        {
            return _context.Families.Any((Family family) => family.Id == id);
        }

        /**
         * Caste une famille en DTO
         * 
         * @param family Famille à caster
         * @return Famille DTO
         */
        internal static FamilyDTO ConvertToFamilyDTO(Family? family)
        {
            FamilyDTO familyDTO = new FamilyDTO();

            if (family != null)
            {
                familyDTO.Id = family.Id;
                familyDTO.Name = family.Name;
                familyDTO.Items = family.Items?.Select((Item item) => ItemController.ConvertItemToDTO(item)).ToArray();
            }

            return familyDTO;
        }
    }
}
