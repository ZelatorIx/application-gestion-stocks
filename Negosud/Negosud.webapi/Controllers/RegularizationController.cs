using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;
using System.Linq;

namespace Negosud.webapi.Controllers
{
    [Route("regularizations")]
    [ApiController]
    public class RegularizationController : ControllerBase
    {
        private readonly NegosudContext _context;

        public RegularizationController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de régularisations
        /// </summary>
        /// <returns>Liste Regularisation</returns>
        [HttpGet]
        public async Task<List<RegularizationDTO>> GetAll()
        {
            return await _context.Regularizations
                .Select((Regularization regularization) => ConvertRegularizationToDTO(regularization))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne un fournisseur suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant du fournisseur</param>
        /// <returns>Fournisseur</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<RegularizationDTO>> GetById(int id)
        {
            Regularization? regularization = await _context.Regularizations.FindAsync(id);

            if (regularization == null)
            {
                return NotFound();
            }

            return Ok(ConvertRegularizationToDTO(regularization));
        }

        /// <summary>
        /// Créer une regularisation
        /// </summary>
        /// <param name="regularizationDTO">regularisation à créer</param>
        /// <returns>Retourne les données de la nouvelle regularisation</returns>
        [HttpPost]
        public async Task<ActionResult<RegularizationDTO>> Post([FromBody] RegularizationDTO regularizationDTO)
        {
            Regularization regularizationResult = new Regularization()

            {
                Date = regularizationDTO.Date,
                Inventorist = regularizationDTO.Inventorist,
            };

            _context.Regularizations.Add(regularizationResult);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetById),
                new { id = regularizationDTO.Id },
                ConvertRegularizationToDTO(regularizationResult)
            );
        }

        /// <summary>
        /// Modifie une régularisation suivant son id
        /// </summary>
        /// <param name="id">Identifiant de la regularisation</param>
        /// <param name="supplierDTO">Informations regularisation</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RegularizationDTO regularizationDTO)
        {
            Regularization? regularization = await _context.Regularizations.FindAsync(id);
            if (regularization == null)
            {
                return NotFound("Selected regularization items does not exist");
            }

            regularization.Date = regularizationDTO.Date;
            regularization.Inventorist = regularizationDTO.Inventorist;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!RegularizationExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
        }

        /// <summary>
        /// Retourne Vrai si la regularisation existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool RegularizationExist(int id)
        {
            return _context.Regularizations.Any((Regularization regularization) => regularization.Id == id);
        }

        /// <summary>
        /// Caste une regularisation en DTO
        /// </summary>
        /// <param name="regularization">Regularisation à caster</param>
        /// <returns>Regularisation DTO</returns>
        internal static RegularizationDTO ConvertRegularizationToDTO(Regularization? regularization)
        {
            RegularizationDTO regularizationDTO = new RegularizationDTO();

            if (regularization != null)
            {
                regularizationDTO.Id = regularization.Id;
                regularizationDTO.Date = regularization.Date;
                regularizationDTO.Inventorist = regularization.Inventorist;
                regularizationDTO.ReasonRegularization = ReasonRegularization.ConvertReasonRegularizationToDTO(regularization.ReasonRegularization);

            }
            return regularizationDTO;
        }

    }
}
