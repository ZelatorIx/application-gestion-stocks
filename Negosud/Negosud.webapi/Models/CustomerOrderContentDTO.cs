namespace Negosud.webapi.Models
{
    public class CustomerOrderContentDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }   
        public float BeforePriceTax { get; set; }   
        public float Vat { get; set; }
        public ItemDTO[]? Items { get; set; }
        public CommandCustomerDTO[]? CommandCustomers { get; set; }
    }
}
