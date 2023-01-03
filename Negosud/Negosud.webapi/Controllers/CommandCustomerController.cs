using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("commands-customer")]
    [ApiController]
    public class CommandCustomerController : ControllerBase
    {
        private readonly NegosudContext _context;

        public CommandCustomerController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste des commandes client
        /// </summary>
        /// <returns>Liste Commande Client</returns>
        [HttpGet]
        public async Task<List<CommandCustomerDTO>> GetAll()
        {
            return await _context.CommandCustomers
                .Select((CommandCustomer commandCustomer) => ConvertCommandCustomerToDTO(commandCustomer))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne une commande client suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant de la commande fournisseur</param>
        /// <returns>Commande Fournisseur</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CommandCustomerDTO>> GetById(int id)
        {
            CommandCustomer? commandCustomer = await _context.CommandCustomers.FindAsync(id);

            if (commandCustomer == null)
            {
                return NotFound();
            }

            return Ok(ConvertCommandCustomerToDTO(commandCustomer));
        }

        /// <summary>
        /// Créer une commande client
        /// </summary>
        /// <param name="supplierDTO"> commande client à créer</param>
        /// <returns>Retourne les données de la nouvelle commande client</returns>
        [HttpPost]
        public async Task<ActionResult<CommandCustomerDTO>> Post([FromBody] CommandCustomerDTO commandCustomerDTO)
        {
            CommandCustomer commandCustomerResult = new CommandCustomer()

            {
                Number = commandCustomerDTO.Number,
                Date = commandCustomerDTO.Date,
                Status = commandCustomerDTO.Status
            };

            _context.CommandCustomers.Add(commandCustomerResult);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetById),
                new { id = commandCustomerDTO.Id },
                ConvertCommandCustomerToDTO(commandCustomerResult)
            );
        }

        /// <summary>
        /// Modifie une commande client suivant son id
        /// </summary>
        /// <param name="id">Identifiant commande client</param>
        /// <param name="commandCustomerDTO">Informations commande client</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CommandCustomerDTO commandCustomerDTO)
        {
            CommandCustomer? commandCustomer = await _context.CommandCustomers.FindAsync(id);
            if (commandCustomer == null)
            {
                return NotFound("Selected command supplier items does not exist");
            }

            commandCustomer.Number = commandCustomerDTO.Number;
            commandCustomer.Date = commandCustomerDTO.Date;
            commandCustomer.Status = commandCustomerDTO.Status;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CommandCustomerExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
        }

        /// <summary>
        /// Retourne Vrai si la commande client existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Vrai si la commande existe</returns>
        private bool CommandCustomerExist(int id)
        {
            return _context.CommandCustomers.Any((CommandCustomer commandCustomer) => commandCustomer.Id == id);
        }

        /// <summary>
        /// Caste une commande client en DTO
        /// </summary>
        /// <param name="supplier">Commande Client à caster</param>
        /// <returns>Commande Client DTO</returns>
        internal static CommandCustomerDTO ConvertCommandCustomerToDTO(CommandCustomer? commandCustomer)
        {
            CommandCustomerDTO commandCustomerDTO = new CommandCustomerDTO();

            if (commandCustomer != null)
            {
                commandCustomerDTO.Id = commandCustomer.Id;
                commandCustomerDTO.Number = commandCustomer.Number;
                commandCustomerDTO.Date = commandCustomer.Date;
                commandCustomerDTO.Status = commandCustomer.Status;

            }
            return commandCustomerDTO;
        }

    }
}
