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
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int CommandCustomerId { get; set; }
        public CommandCustomer CommandCustomer { get; set; }
    }
}
