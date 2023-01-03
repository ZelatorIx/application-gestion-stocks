using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("suppliers-order-content")]
    [ApiController]
    public class SupplierOrderContentController : ControllerBase
    {


        private readonly NegosudContext _context;

        public SupplierOrderContentController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de contenus de commandes fournisseur
        /// </summary>
        /// <returns>Liste contenu commande fournisseur</returns>
        [HttpGet]
        public async Task<List<SupplierOrderContentDTO>> GetAll()
        {
            return await _context.SupplierOrderContents
                .Select((SupplierOrderContent supplierOrderContent) => ConvertSupplierOrderContentToDTO(supplierOrderContent))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne le contenu d'une commande fournisseur suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant du contenu de la commande fournisseur</param>
        /// <returns>Contenu Commande Fournisseur</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierOrderContentDTO>> GetById(int id)
        {
            SupplierOrderContent? supplierOrderContent = await _context.SupplierOrderContents.FindAsync(id);

            if (supplierOrderContent == null)
            {
                return NotFound();
            }

            return Ok(ConvertSupplierOrderContentToDTO(supplierOrderContent));
        }

        /// <summary>
        /// Créer le contenu d'une commande fournisseur
        /// </summary>
        /// <param name="supplierDTO">contenu commande fournisseur à créer</param>
        /// <returns>Retourne les données du nouveau contenu commande fournisseur</returns>
        [HttpPost]
        public async Task<ActionResult<SupplierOrderContentDTO>> Post([FromBody] SupplierOrderContentDTO supplierOrderContentDTO)
        {
            SupplierOrderContent supplierOrderContentResult = new SupplierOrderContent()

            {
                Quantity = supplierOrderContentDTO.Quantity,
                BeforePriceTax = supplierOrderContentDTO.BeforePriceTax,
                VAT = supplierOrderContentDTO.VAT
            };

            _context.SupplierOrderContents.Add(supplierOrderContentResult);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetById),
                new { id = supplierOrderContentDTO.Id },
                ConvertSupplierOrderContentToDTO(supplierOrderContentResult)
            );
        }

        /// <summary>
        /// Modifie le contenu d'une commande fournisseur suivant son id
        /// </summary>
        /// <param name="id">Identifiant du contenu de la commande fournisseur</param>
        /// <param name="commandSupplierDTO">Informations du contenu de la commande fournisseur</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SupplierOrderContentDTO supplierOrderContentDTO)
        {
            SupplierOrderContent? supplierOrderContent = await _context.SupplierOrderContents.FindAsync(id);
            if (supplierOrderContent == null)
            {
                return NotFound("Selected supplier order content items does not exist");
            }

            supplierOrderContent.Quantity = supplierOrderContentDTO.Quantity;
            supplierOrderContent.BeforePriceTax = supplierOrderContent.BeforePriceTax;
            supplierOrderContent.VAT = supplierOrderContent.VAT;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!SupplierOrderContentExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
        }

        /// <summary>
        /// Retourne Vrai si le contenu d'une commande fournisseur existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Vrai si la commande existe</returns>
        private bool SupplierOrderContentExist(int id)
        {
            return _context.SupplierOrderContents.Any((SupplierOrderContent supplierOrderContent) => supplierOrderContent.Id == id);
        }

        /// <summary>
        /// Caste le contenu d'une commande fournisseur en DTO
        /// </summary>
        /// <param name="supplier">Commande Fournisseur à caster</param>
        /// <returns>Commande Fournisseur DTO</returns>
        internal static SupplierOrderContentDTO ConvertSupplierOrderContentToDTO(SupplierOrderContent? supplierOrderContent)
        {
            SupplierOrderContentDTO supplierOrderContentDTO = new SupplierOrderContentDTO();

            if (supplierOrderContent != null)
            {
                supplierOrderContentDTO.Id = supplierOrderContent.Id;
                supplierOrderContentDTO.Quantity = supplierOrderContent.Quantity;
                supplierOrderContentDTO.BeforePriceTax = supplierOrderContent.BeforePriceTax;
                supplierOrderContentDTO.VAT = supplierOrderContent.VAT;

            }
            return supplierOrderContentDTO;
        }


    }
}
