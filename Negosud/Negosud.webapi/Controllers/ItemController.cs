using Microsoft.AspNetCore.Mvc;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace Negosud.webapi.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : Controller
    {
        private readonly NegosudContext _context;

        public ItemController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne une liste d'articles
        /// </summary>
        /// <returns>
        /// Liste d'articles</returns>
        [HttpGet]
        public async Task<List<ItemDTO>> GetAll()
        {
            return await _context.Items
                .Select((Item item) => ConvertItemToDTO(item))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne un article par son identifiant
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <returns>Article</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDTO>> GetById(int id)
        {
            Item? item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound("This item does not exist.");
            }

            return Ok(ConvertItemToDTO(item));
        }

        /// <summary>
        /// Crée un article
        /// </summary>
        /// <param name="itemDTO">Informations de l'article</param>
        /// <returns>Résultat de la requête POST</returns>
        [HttpPost]
        public async Task<ActionResult<ItemDTO>> Post([FromBody] ItemDTO itemDTO)
        {
            Family? family = await _context.Families.FindAsync(itemDTO.Family.Id);
            if (family == null)
            {
                return NotFound("This family does not exist.");
            }

            Item item = new Item()
            {
                Name = itemDTO.Name,
                Description = itemDTO.Description,
                PurchasePriceBT = itemDTO.PurchasePriceBT,
                SellingPriceBT = itemDTO.SellingPriceBT,
                Vat = itemDTO.Vat,
                Picture = itemDTO.Picture,
                MinLimit = itemDTO.MinLimit,
                YearItem = itemDTO.YearItem,
                Family = family
            };

            try {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(item.Id);
        }

        /// <summary>
        /// Modifie un article
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <param name="itemDTO">Informations de l'article</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ItemDTO itemDTO)
        {
            Item? item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound("This item does not exist.");
            }

            Family? family = await _context.Families.FindAsync(itemDTO.Family.Id);
            if (family == null)
            {
                return NotFound("Selected family does not exist.");
            }

            item.Name = itemDTO.Name;
            item.Description = itemDTO.Description;
            item.PurchasePriceBT = itemDTO.PurchasePriceBT;
            item.SellingPriceBT = itemDTO.SellingPriceBT;
            item.Vat = itemDTO.Vat;
            item.Picture = itemDTO.Picture;
            item.MinLimit = itemDTO.MinLimit;
            item.YearItem = itemDTO.YearItem;
            item.Family = family;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ItemExist(id))
            {
                return NotFound("This item does not exist.");
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Item? item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound("This item does not exist.");
            }

            if (
                item.CustomerOrderContents != null ||
                item.SupplierOrderContents != null ||
                item.StockMovements != null
               )
            {
                return StatusCode(403, "You can't delete item wich have one or more references.");
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Retourne vrai si l'article existe dans la base de données
        /// </summary>
        /// <param name="id">Identifiant de l'article</param>
        /// <returns>Vrai si l'article existe</returns>
        private bool ItemExist(int id)
        {
            return _context.Items.Any((Item item) => item.Id == id);
        }

        /// <summary>
        /// Caste un article en DTO
        /// </summary>
        /// <param name="item">Article à caster</param>
        /// <returns>Article DTO</returns>
        internal static ItemDTO ConvertItemToDTO(Item? item)
        {
            ItemDTO itemDTO = new ItemDTO();

            if (item != null)
            {
                itemDTO.Id = item.Id;
                itemDTO.Name = item.Name;
                itemDTO.Description = item.Description;
                itemDTO.PurchasePriceBT = item.PurchasePriceBT;
                itemDTO.SellingPriceBT = item.SellingPriceBT;
                itemDTO.Vat = item.Vat;
                itemDTO.Picture = item.Picture;
                itemDTO.MinLimit = item.MinLimit;
                itemDTO.YearItem = item.YearItem;
                if (item.Family == null)
                {
                    itemDTO.Family = FamilyController.ConvertFamilyToDTO(item.FamilyId);
                }
                else
                {
                    itemDTO.Family = FamilyController.ConvertFamilyToDTO(item.Family);
                }
            }

            return itemDTO;
        }
    }
}

