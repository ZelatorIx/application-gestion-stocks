using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess;
using Negosud.dataaccess.Tables;
using Negosud.webapi.Models;
using System.Net.NetworkInformation;

namespace Negosud.webapi.Controllers
{
    [Route("suppliers")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly NegosudContext _context;

        public SupplierController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de fournisseurs
        /// </summary>
        /// <returns>Liste Fournisseur</returns>
        [HttpGet]
        public async Task<List<SupplierDTO>> GetAll()
        {
            return await _context.Suppliers
                .Select((Supplier supplier) => ConvertSupplierToDTO(supplier))
                .ToListAsync();
        }
        
        /// <summary>
        /// Retourne un fournisseur suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant du fournisseur</param>
        /// <returns>Fournisseur</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierDTO>> GetById(int id)
        {
            Supplier? supplier = await _context.Suppliers.FindAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(ConvertSupplierToDTO(supplier));
        }

        /// <summary>
        /// Créer un fournisseur
        /// </summary>
        /// <param name="supplierDTO">fournisseur à créer</param>
        /// <returns>Retourne les données du nouveau fournisseur</returns>
        [HttpPost]
        public async Task<ActionResult<SupplierDTO>> Post([FromBody] SupplierDTO supplierDTO)
        {
            Supplier supplierResult = new Supplier() 
            
            { Name = supplierDTO.Name, 
              Email = supplierDTO.Email,
              PhoneNumber = supplierDTO.PhoneNumber , 
              PhysicalAddress = supplierDTO.PhysicalAddress,
              PostalCode = supplierDTO.PostalCode,
              Town = supplierDTO.Town
            };

            try
            {
                _context.Suppliers.Add(supplierResult);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(supplierResult.Id);
        }

        /// <summary>
        /// Modifie un fournisseur suivant son id
        /// </summary>
        /// <param name="id">Identifiant du fournisseur</param>
        /// <param name="supplierDTO">Informations du fournisseur</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SupplierDTO supplierDTO)
        {
            Supplier? supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound("Selected supplier items does not exist");
            }

            supplier.Name = supplierDTO.Name;
            supplier.Email = supplierDTO.Email;
            supplier.PhoneNumber = supplierDTO.PhoneNumber;
            supplier.PhysicalAddress = supplierDTO.PhysicalAddress;
            supplier.PostalCode = supplierDTO.PostalCode;
            supplier.Town = supplierDTO.Town;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!SupplierExist(id))
            {
                return NotFound();
            }

            return StatusCode(304);
        }
        
        /// <summary>
        /// Retourne Vrai si le fournisseur existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool SupplierExist(int id)
        {
            return _context.Suppliers.Any((Supplier supplier) => supplier.Id == id);
        }

        /// <summary>
        /// Supprime un fournisseur suivant son id
        /// </summary>
        /// <param name="id">Identifiant du fournisseur</param>
        /// <returns>Résultat de la requête delete</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Supplier? supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            if (supplier.CommandSuppliers != null && supplier.CommandSuppliers.Count > 0)
            {
                return Forbid();
            }

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Caste un fournisseur en DTO
        /// </summary>
        /// <param name="supplier">Fournisseur à caster</param>
        /// <returns>Fournisseur DTO</returns>
        internal static SupplierDTO ConvertSupplierToDTO(Supplier? supplier)
        {
            SupplierDTO supplierDTO = new SupplierDTO();

            if (supplier != null)
            {
                supplierDTO.Id = supplier.Id;
                supplierDTO.Name = supplier.Name;
                supplierDTO.Email = supplier.Email;
                supplierDTO.PhoneNumber = supplier.PhoneNumber;
                supplierDTO.PhysicalAddress = supplier.PhysicalAddress;
                supplierDTO.PostalCode = supplier.PostalCode;
                supplierDTO.Town = supplier.Town;
                
            }
            return supplierDTO;
        }


    }
}
