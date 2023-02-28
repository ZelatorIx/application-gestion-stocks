namespace Negosud.MVCWeb.Types
{
    public class CustomerOrderContent
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float BeforePriceTax { get; set; }
        public float Vat { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int CommandCustomerId { get; set; }
        public CommandCustomer CommandCustomer { get; set; }
    }
}
