namespace Negosud.dataaccess.Tables
{
    public class SupplierOrderContent
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float BeforePriceTax { get; set; }
        public float VAT { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int CommandSupplierId { get; set; }
        public CommandSupplier CommandSupplier { get; set; }
    }
}
