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
        /// Retourne une liste d'items
        /// </summary>
        /// <returns>
        /// Liste d'items</returns>
        [HttpGet]
        public async Task<List<ItemDTO>> GetAll()
        {
            return await _context.Items
                .Select((Item item) => ConvertItemToDTO(item))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne un item par son identifiant
        /// </summary>
        /// <param name="id">Identifiant de l'item</param>
        /// <returns>Item</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDTO>> GetById(int id)
        {
            Item? item = await _context.Items.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(ConvertItemToDTO(item));
        }

        /// <summary>
        /// Crée un item
        /// </summary>
        /// <param name="itemDTO">Informations de l'item</param>
        /// <returns>Résultat de la requête POST</returns>
        [HttpPost]
        public async Task<ActionResult<ItemDTO>> Post([FromBody] ItemDTO itemDTO)
        {
            Family family = new Family() { Name = itemDTO.ItemFamily.Name };

            Item itemResult = new Item()
            {
                Name = itemDTO.Name,
                Description = itemDTO.Description,
                PurchasePriceBT = itemDTO.PurchasePriceBT,
                SellingPriceBT = itemDTO.SellingPriceBT,
                Vat = itemDTO.Vat,
                Picture = itemDTO.Picture,
                MinLimit = itemDTO.MinLimit,
                YearItem = itemDTO.YearItem,
                ItemFamily = family
            };

            _context.Items.Add(itemResult);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetById),
                new { id = itemDTO.Id },
                ConvertItemToDTO(itemResult)
            );
        }

        /// <summary>
        /// Caste un item en DTO
        /// </summary>
        /// <param name="item">Item à caster</param>
        /// <returns>Item DTO</returns>
        internal static ItemDTO ConvertItemToDTO(Item? item)
        {
            ItemDTO itemDTO = new ItemDTO();

            if (item != null)
            {
                itemDTO.Name = item.Name;
                itemDTO.Description = item.Description;
                itemDTO.ItemFamily = FamilyController.ConvertFamilyToDTO(item.ItemFamily);
            }

            return itemDTO;
        }
    }
}

