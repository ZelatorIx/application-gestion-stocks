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
                return NotFound();
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
            Family? family = await _context.Families.FindAsync(itemDTO.ItemFamily.Id);
            if (family == null)
            {
                return BadRequest();
            }

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
                return NotFound();
            }

            Family family = new Family() { Name = item.ItemFamily.Name };
            var a = _context.Items
                .Select((Item item) => item.ItemFamily)
                .Where((Family family) => family.Id == item.ItemFamily.Id);

            item.Name = itemDTO.Name ?? item.Name;
            item.Description = itemDTO.Description ?? item.Description;
            item.PurchasePriceBT = itemDTO.PurchasePriceBT;
            item.SellingPriceBT = itemDTO.SellingPriceBT;
            item.Vat = itemDTO.Vat;
            item.Picture = itemDTO.Picture ?? item.Picture;
            item.MinLimit = itemDTO.MinLimit;
            item.YearItem = itemDTO.YearItem;
            item.ItemFamily = family;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ItemExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
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
                itemDTO.Name = item.Name;
                itemDTO.Description = item.Description;
                itemDTO.ItemFamily = FamilyController.ConvertFamilyToDTO(item.ItemFamily);
            }

            return itemDTO;
        }
    }
}

