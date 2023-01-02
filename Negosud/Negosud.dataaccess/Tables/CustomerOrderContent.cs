namespace Negosud.dataaccess.Tables
{
    public class CustomerOrderContent
    {
        public int Id { get; set; }
        public int Quantity { get; set; }   
        public float BeforePriceTax { get; set; }   
        public float Vat { get; set; }
        public Item[]? Items { get; set; }
    }
}
