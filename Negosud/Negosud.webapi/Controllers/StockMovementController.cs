using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("stock-movements")]
    [ApiController]
    public class StockMovementController : ControllerBase
    {
        private readonly NegosudContext _context;

        public StockMovementController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de mouvement de stock
        /// </summary>
        /// <returns>Liste de mouvement de stock</returns>
        [HttpGet]
        public async Task<List<StockMovementDTO>> GetAll()
        {
            return await _context.StockMovements
                .Select((StockMovement stockMovement) => ConvertStockMovementToDTO(stockMovement))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne un mouvement de stock suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant du mouvement de stock</param>
        /// <returns>Fournisseur</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<StockMovementDTO>> GetById(int id)
        {
            StockMovement? stockMovement = await _context.StockMovements.FindAsync(id);

            if (stockMovement == null)
            {
                return NotFound();
            }

            return Ok(ConvertStockMovementToDTO(stockMovement));
        }

        /// <summary>
        /// Créer un mouvement de stock
        /// </summary>
        /// <param name="stockMovementDTO">mouvement de stock à créer</param>
        /// <returns>Retourne les données du mouvement de stock</returns>
        [HttpPost]
        public async Task<ActionResult<StockMovementDTO>> Post([FromBody] StockMovementDTO stockMovementDTO)
        {
            StockMovement stockMovementResult = new StockMovement()

            {
                Quantity = stockMovementDTO.Quantity,
            };

            try
            {
                _context.StockMovements.Add(stockMovementResult);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(stockMovementResult.Id);
        }

        /// <summary>
        /// Modifie un mouvement de stock suivant son id
        /// </summary>
        /// <param name="id">Identifiant du mouvement de stock</param>
        /// <param name="stockMovementDTO">Informations mouvement de stock</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] StockMovementDTO stockMovementDTO)
        {
            StockMovement? stockMovement = await _context.StockMovements.FindAsync(id);
            if (stockMovement == null)
            {
                return NotFound("Selected stock movement items does not exist");
            }

            stockMovement.Quantity = stockMovementDTO.Quantity;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!StockMovementExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
        }

        /// <summary>
        /// Retourne Vrai si le mouvement de stock existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool StockMovementExist(int id)
        {
            return _context.StockMovements.Any((StockMovement stockMovement) => stockMovement.Id == id);
        }

        /// <summary>
        /// Caste un mouvement de stock en DTO
        /// </summary>
        /// <param name="stockMovement">Mouvement de stock à caster</param>
        /// <returns>Mouvment de stock DTO</returns>
        internal static StockMovementDTO ConvertStockMovementToDTO(StockMovement? stockMovement)
        {
            StockMovementDTO stockMovementDTO = new StockMovementDTO();

            if (stockMovement != null)
            {
                stockMovementDTO.Id = stockMovement.Id;
                stockMovementDTO.Quantity = stockMovement.Quantity;
            }
            return stockMovementDTO;
        }

    }
}
