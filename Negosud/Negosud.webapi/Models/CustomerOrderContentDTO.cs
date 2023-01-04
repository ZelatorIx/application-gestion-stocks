namespace Negosud.webapi.Models
{
    public class CustomerOrderContentDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }   
        public float BeforePriceTax { get; set; }   
        public float Vat { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
        public int CommandCustomerId { get; set; }
        public CommandCustomerDTO CommandCustomer { get; set; }
    }
}
