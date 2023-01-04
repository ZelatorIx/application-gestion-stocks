using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("reasons-regularization")]
    [ApiController]
    public class ReasonRegularizationController : ControllerBase
    {

        private readonly NegosudContext _context;

        public ReasonRegularizationController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de raison de régularisations
        /// </summary>
        /// <returns>Liste Raison Regularisation</returns>
        [HttpGet]
        public async Task<List<ReasonRegularizationDTO>> GetAll()
        {
            return await _context.ReasonRegularizations
                .Select((ReasonRegularization reasonRegularization) => ConvertReasonRegularizationToDTO(reasonRegularization))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne une raison de régularisation suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la raison de régularisation</param>
        /// <returns>Raison Regularisation</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ReasonRegularizationDTO>> GetById(int id)
        {
            ReasonRegularization? reasonRegularization = await _context.ReasonRegularizations.FindAsync(id);

            if (reasonRegularization == null)
            {
                return NotFound();
            }

            return Ok(ConvertReasonRegularizationToDTO(reasonRegularization));
        }

        /// <summary>
        /// Créer une raison de regularisation
        /// </summary>
        /// <param name="regularizationDTO">regularisation à créer</param>
        /// <returns>Retourne les données de la nouvelle regularisation</returns>
        [HttpPost]
        public async Task<ActionResult<ReasonRegularizationDTO>> Post([FromBody] ReasonRegularizationDTO reasonRegularizationDTO)
        {
            ReasonRegularization reasonRegularizationResult = new ReasonRegularization()

            {
                Title = reasonRegularizationDTO.Title,
                Sense = reasonRegularizationDTO.Sense,
            };

            try
            {
                _context.ReasonRegularizations.Add(reasonRegularizationResult);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(reasonRegularizationResult.Id);
        }

        /// <summary>
        /// Modifie une raison de régularisation suivant son id
        /// </summary>
        /// <param name="id">Identifiant de la raison de regularisation</param>
        /// <param name="reasonRegularizationDTO">Informations raison regularisation</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ReasonRegularizationDTO reasonRegularizationDTO)
        {
            ReasonRegularization? reasonRegularization = await _context.ReasonRegularizations.FindAsync(id);
            if (reasonRegularization == null)
            {
                return NotFound("Selected reason regularization items does not exist");
            }

            reasonRegularization.Title = reasonRegularizationDTO.Title;
            reasonRegularization.Sense = reasonRegularizationDTO.Sense;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ReasonRegularizationExist(id))
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
        private bool ReasonRegularizationExist(int id)
        {
            return _context.ReasonRegularizations.Any((ReasonRegularization reasonRegularization) => reasonRegularization.Id == id);
        }

        /// <summary>
        /// Caste une raison de regularisation en DTO
        /// </summary>
        /// <param name="reasonRegularization">Raison de la Regularisation à caster</param>
        /// <returns>Raison Regularisation DTO</returns>
        internal static ReasonRegularizationDTO ConvertReasonRegularizationToDTO(ReasonRegularization? reasonRegularization)
        {
            ReasonRegularizationDTO reasonRegularizationDTO = new ReasonRegularizationDTO();

            if (reasonRegularization != null)
            {
                reasonRegularizationDTO.Id = reasonRegularization.Id;
                reasonRegularizationDTO.Title = reasonRegularization.Title;
                reasonRegularizationDTO.Sense = reasonRegularization.Sense;

            }
            return reasonRegularizationDTO;
        }






    }
}
