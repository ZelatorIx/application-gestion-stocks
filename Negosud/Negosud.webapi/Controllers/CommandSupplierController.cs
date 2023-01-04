using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("commands-supplier")]
    [ApiController]
    public class CommandSupplierController : ControllerBase
    {

        private readonly NegosudContext _context;

        public CommandSupplierController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste des commandes fournisseur
        /// </summary>
        /// <returns>Liste Commande Fournisseur</returns>
        [HttpGet]
        public async Task<List<CommandSupplierDTO>> GetAll()
        {
            return await _context.CommandSuppliers
                .Select((CommandSupplier commandSupplier) => ConvertCommandSupplierToDTO(commandSupplier))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne une commande fournisseur suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la commande fournisseur</param>
        /// <returns>Commande Fournisseur</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CommandSupplierDTO>> GetById(int id)
        {
            CommandSupplier? commandSupplier = await _context.CommandSuppliers.FindAsync(id);

            if (commandSupplier == null)
            {
                return NotFound();
            }

            return Ok(ConvertCommandSupplierToDTO(commandSupplier));
        }

        /// <summary>
        /// Créer une commande fournisseur
        /// </summary>
        /// <param name="supplierDTO"> commande fournisseur à créer</param>
        /// <returns>Retourne les données de la nouvelle commande fournisseur</returns>
        [HttpPost]
        public async Task<ActionResult<CommandSupplierDTO>> Post([FromBody] CommandSupplierDTO commandSupplierDTO)
        {
            Supplier? supplier = await _context.Suppliers.FindAsync(commandSupplierDTO.Supplier.Id);
            if (supplier == null)
            {
                return NotFound("This supplier does not exist.");
            }

            CommandSupplier commandSupplierResult = new CommandSupplier()
            {
                Number = commandSupplierDTO.Number,
                Date = commandSupplierDTO.Date,
                Status = commandSupplierDTO.Status,
                Supplier = supplier
            };

            try
            {
                _context.CommandSuppliers.Add(commandSupplierResult);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(commandSupplierResult.Id);
        }

        /// <summary>
        /// Modifie une commande fournisseur suivant son id
        /// </summary>
        /// <param name="id">Identifiant commande fournisseur</param>
        /// <param name="commandSupplierDTO">Informations commande fournisseur</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CommandSupplierDTO commandSupplierDTO)
        {
            CommandSupplier? commandSupplier = await _context.CommandSuppliers.FindAsync(id);
            if (commandSupplier == null)
            {
                return NotFound("Selected command supplier items does not exist");
            }

            Supplier? supplier = await _context.Suppliers.FindAsync(commandSupplier.Supplier.Id);
            if (supplier == null)
            {
                return NotFound("This supplier does not exist.");
            }

            commandSupplier.Number = commandSupplierDTO.Number;
            commandSupplier.Date = commandSupplierDTO.Date;
            commandSupplier.Status = commandSupplierDTO.Status;
            commandSupplier.Supplier = supplier;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CommandSupplierExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
        }

        /// <summary>
        /// Retourne Vrai si la commande fournisseur existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Vrai si la commande existe</returns>
        private bool CommandSupplierExist(int id)
        {
            return _context.CommandSuppliers.Any((CommandSupplier commandSupplier) => commandSupplier.Id == id);
        }

        /// <summary>
        /// Caste une commande fournisseur en DTO
        /// </summary>
        /// <param name="commandSupplier">Commande Fournisseur à caster</param>
        /// <returns>Commande Client DTO</returns>
        internal static CommandSupplierDTO ConvertCommandSupplierToDTO(CommandSupplier? commandSupplier)
        {
            CommandSupplierDTO commandSupplierDTO = new CommandSupplierDTO();

            if (commandSupplier != null)
            {
                commandSupplierDTO.Id = commandSupplier.Id;
                commandSupplierDTO.Number = commandSupplier.Number;
                commandSupplierDTO.Date = commandSupplier.Date;
                commandSupplierDTO.Status = commandSupplier.Status;

            }
            return commandSupplierDTO;
        }
        

    }
}
