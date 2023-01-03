using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string PhysicalAddress { get; set; } = "";
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Town { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        public List<CommandSupplier>? CommandSuppliers { get; set; }
    }
}
