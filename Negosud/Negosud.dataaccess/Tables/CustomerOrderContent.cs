using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class CustomerOrderContent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float BeforePriceTax { get; set; }
        [Required]
        public float Vat { get; set; }
        public List<Item>? Items { get; set; }
        public List<CommandCustomer>? CommandCustomers { get; set; }
    }
}
