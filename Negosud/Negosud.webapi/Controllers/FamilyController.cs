using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Negosud.dataaccess;
using Negosud.dataaccess.Tables;
using Negosud.webapi.Models;
using System.Data;

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("families")]
    public class FamilyController : ControllerBase
    {
        private readonly NegosudContext _context;

        public FamilyController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste des familles
        /// </summary>
        /// <returns>Liste des familles</returns>
        [HttpGet]
        public async Task<List<FamilyDTO>> GetAll()
        {
            return await _context.Families
                .Select((Family family) => ConvertFamilyToDTO(family))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne une famille par son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la famille</param>
        /// <returns>Famille</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FamilyDTO>> GetById(int id)
        {
            Family? family = await _context.Families.FindAsync(id);

            if (family == null)
            {
                return NotFound("This family does not exist.");
            }

            return Ok(ConvertFamilyToDTO(family));
        }

        /// <summary>
        /// Crée une famille
        /// </summary>
        /// <param name="familyDTO">Famille à créer</param>
        /// <returns>Résultat de la requête POST</returns>
        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] FamilyDTO familyDTO)
        {
            Family familyResult = new Family() { Name = familyDTO.Name };

            try
            {
                _context.Families.Add(familyResult);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(familyResult.Id);
        }

        /// <summary>
        /// Modifie une famille par son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la famille</param>
        /// <param name="familyDTO">Informations de la famille</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] FamilyDTO familyDTO)
        {
            Family? family = await _context.Families.FindAsync(id);
            if (family == null)
            {
                return NotFound("This family does not exist.");
            }

            family.Name = familyDTO.Name;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!FamilyExist(id))
            {
                return NotFound("This family does not exist.");
            }

            return Ok();
        }

        /// <summary>
        /// Supprime une famille par son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la famille</param>
        /// <returns>Status de la requête DELETE</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Family? family = await _context.Families.FindAsync(id);
            if (family == null)
            {
                return NotFound("This family does not exist.");
            }

            List<Item> items = _context.Items.Where((Item i) => i.FamilyId == id).ToList();
            if (items.Count > 0)
            {
                return Forbid("You can't delete family which have one or more item.");
            }

            try
            {
                _context.Families.Remove(family);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        /// <summary>
        /// Retourne vrai si la famille existe dans la base de données
        /// </summary>
        /// <param name="id">Identifiant de la famille</param>
        /// <returns>Vrai si la famille existe</returns>
        internal bool FamilyExist(int id)
        {
            return _context.Families.Any((Family family) => family.Id == id);
        }

        /// <summary>
        /// Caste une famille en DTO
        /// </summary>
        /// <param name="family">Famille à caster</param>
        /// <returns>Famille DTO</returns>
        internal static FamilyDTO ConvertFamilyToDTO(Family? family)
        {
            try
            {
                FamilyDTO familyDTO = new FamilyDTO();
            
                if (family != null)
                {
                    familyDTO.Id = family.Id;
                    familyDTO.Name = family.Name;
                }

                return familyDTO;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Caste une famille en DTO
        /// </summary>
        /// <param name="familyId">Identifiant de la famille à caster</param>
        /// <returns>Famille DTO</returns>
        internal static FamilyDTO ConvertFamilyToDTO(int familyId)
        {
            Family? family;

            using (NegosudContext context = new NegosudContext())
            {
                family = context.Families.Find(familyId);
            }
            if (family == null)
            {
                throw new Exception("Family can't be null.");
            }

            return ConvertFamilyToDTO(family);
        }
    }
}
