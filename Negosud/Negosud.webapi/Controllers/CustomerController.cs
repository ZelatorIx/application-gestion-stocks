using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.dataaccess.Tables;
using Negosud.dataaccess;
using Negosud.webapi.Models;

namespace Negosud.webapi.Controllers
{
    [Route("customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly NegosudContext _context;

        public CustomerController()
        {
            _context = new NegosudContext();
        }

        /// <summary>
        /// Retourne la liste de clients
        /// </summary>
        /// <returns>Liste Client</returns>
        [HttpGet]
        public async Task<List<CustomerDTO>> GetAll()
        {
            return await _context.Customers
                .Select((Customer customer) => ConvertCustomerToDTO(customer))
                .ToListAsync();
        }

        /// <summary>
        /// Retourne un client suivant son identifiant
        /// </summary>
        /// <param name="id">Identifiant du client</param>
        /// <returns>Client</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetById(int id)
        {
            Customer? customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(ConvertCustomerToDTO(customer));
        }

        /// <summary>
        /// Créer un client
        /// </summary>
        /// <param name="customerDTO">client à créer</param>
        /// <returns>Retourne les données du nouveau client</returns>
        [HttpPost]
        public async Task<ActionResult<CustomerDTO>> Post([FromBody] CustomerDTO customerDTO)
        {
            Customer customerResult = new Customer()
            {
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                Email = customerDTO.Email,
                PhoneNumber = customerDTO.PhoneNumber,
                PhysicalAddress = customerDTO.PhysicalAddress,
                PostalCode = customerDTO.PostalCode,
                Town = customerDTO.Town
            };

            try
            {
                _context.Customers.Add(customerResult);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(customerResult.Id);
        }

        /// <summary>
        /// Modifie un client suivant son id
        /// </summary>
        /// <param name="id">Identifiant du client</param>
        /// <param name="customerDTO">Informations du client</param>
        /// <returns>Status de la requête PUT</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CustomerDTO customerDTO)
        {
            Customer? customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound("Selected customer items does not exist");
            }

            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.Email = customerDTO.Email;
            customer.PhoneNumber = customerDTO.PhoneNumber;
            customer.PhysicalAddress = customerDTO.PhysicalAddress;
            customer.PostalCode = customerDTO.PostalCode;
            customer.Town = customerDTO.Town;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!CustomerExist(id))
            {
                return NotFound();
            }

            return Ok();
        }

        /// <summary>
        /// Retourne Vrai si le client existe déjà
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool CustomerExist(int id)
        {
            return _context.Customers.Any((Customer customer) => customer.Id == id);
        }

        /// <summary>
        /// Supprime un client suivant son id
        /// </summary>
        /// <param name="id">Identifiant du client</param>
        /// <returns>Résultat de la requête delete</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Customer? customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            if (customer.CommandCustomers != null && customer.CommandCustomers.Count > 0)
            {
                return Forbid();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return Ok();
        }

        /// <summary>
        /// Caste un client en DTO
        /// </summary>
        /// <param name="customer">Client à caster</param>
        /// <returns>Client DTO</returns>
        internal static CustomerDTO ConvertCustomerToDTO(Customer? customer)
        {
            CustomerDTO customerDTO = new CustomerDTO();

            if (customer != null)
            {
                customerDTO.Id = customer.Id;
                customerDTO.FirstName = customer.FirstName;
                customerDTO.LastName = customer.LastName;
                customerDTO.Email = customer.Email;
                customerDTO.PhoneNumber = customer.PhoneNumber;
                customerDTO.PhysicalAddress = customer.PhysicalAddress;
                customerDTO.PostalCode = customer.PostalCode;
                customerDTO.Town = customer.Town;

            }

            return customerDTO;
        }

    }
}
