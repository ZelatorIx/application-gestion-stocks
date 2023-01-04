using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("commands-order-content")]
    [ApiController]
    public class CommandOrderContentController : ControllerBase
    {
        private readonly NegosudContext _context;

        public CommandOrderContentController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de contenus de commandes client
        /// </summary>
        /// <returns>Liste contenu commande client</returns>
        [HttpGet]
        public async Task<List<CustomerOrderContentDTO>> GetAll()
        {
            return await _context.CustomerOrderContents
                .Select((CustomerOrderContent customerOrderContent) => ConvertCustomerOrderContentToDTO(customerOrderContent))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne le contenu d'une commande client suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant du contenu de la commande client</param>
        /// <returns>Contenu Commande Client</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerOrderContentDTO>> GetById(int id)
        {
            CustomerOrderContent? customerOrderContent = await _context.CustomerOrderContents.FindAsync(id);

            if (customerOrderContent == null)
            {
                return NotFound();
            }

            return Ok(ConvertCustomerOrderContentToDTO(customerOrderContent));
        }

        /// <summary>
        /// Créer le contenu d'une commande client
        /// </summary>
        /// <param name="supplierOrderContentDTO">contenu commande client à créer</param>
        /// <returns>Retourne les données du nouveau contenu commande client</returns>
        [HttpPost]
        public async Task<ActionResult<CustomerOrderContentDTO>> Post([FromBody] CustomerOrderContentDTO customerOrderContentDTO)
        {
            CustomerOrderContent customerOrderContentResult = new CustomerOrderContent()

            {
                Quantity = customerOrderContentDTO.Quantity,
                BeforePriceTax = customerOrderContentDTO.BeforePriceTax,
                Vat = customerOrderContentDTO.Vat
            };

            _context.CustomerOrderContents.Add(customerOrderContentResult);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(customerOrderContentResult.Id);
        }

        /// <summary>
        /// Modifie le contenu d'une commande client suivant son id
        /// </summary>
        /// <param name="id">Identifiant du contenu de la commande client</param>
        /// <param name="customerOrderContentDTO">Informations du contenu de la commande client</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CustomerOrderContentDTO customerOrderContentDTO)
        {
            CustomerOrderContent? customerOrderContent = await _context.CustomerOrderContents.FindAsync(id);
            if (customerOrderContent == null)
            {
                return NotFound("Selected customer order content items does not exist");
            }

            customerOrderContent.Quantity = customerOrderContentDTO.Quantity;
            customerOrderContent.BeforePriceTax = customerOrderContentDTO.BeforePriceTax;
            customerOrderContent.Vat = customerOrderContentDTO.Vat;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CustomerOrderContentExist(id))
            {
                return NotFound();
            }

            return Ok();
        }

        /// <summary>
        /// Retourne Vrai si le contenu d'une commande client existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Vrai si la commande existe</returns>
        private bool CustomerOrderContentExist(int id)
        {
            return _context.CustomerOrderContents.Any((CustomerOrderContent customerOrderContent) => customerOrderContent.Id == id);
        }

        /// <summary>
        /// Caste le contenu d'une commande fournisseur en DTO
        /// </summary>
        /// <param name="customerOrderContent">Commande Fournisseur à caster</param>
        /// <returns>Commande Fournisseur DTO</returns>
        internal static CustomerOrderContentDTO ConvertCustomerOrderContentToDTO(CustomerOrderContent? customerOrderContent)
        {
            CustomerOrderContentDTO customerOrderContentDTO = new CustomerOrderContentDTO();

            if (customerOrderContent != null)
            {
                customerOrderContentDTO.Id = customerOrderContent.Id;
                customerOrderContentDTO.Quantity = customerOrderContent.Quantity;
                customerOrderContentDTO.BeforePriceTax = customerOrderContent.BeforePriceTax;
                customerOrderContentDTO.Vat = customerOrderContent.Vat;

            }
            return customerOrderContentDTO;
        }


    }
}
