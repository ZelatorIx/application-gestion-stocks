using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Tables
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = "";
        [Required]
        public string LastName { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string PhysicalAddress { get; set; } = "";
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Town { get; set; } = "";
        public CommandCustomer[]? CommandCustomers { get; set; }
    }
}
