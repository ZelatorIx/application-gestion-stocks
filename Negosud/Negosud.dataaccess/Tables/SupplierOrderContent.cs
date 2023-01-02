namespace Negosud.dataaccess.Tables
{
    public class SupplierOrderContent
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float BeforePriceTax { get; set; }
        public float VAT { get; set; }
        public Item[]? Items { get; set; }
    }
}
