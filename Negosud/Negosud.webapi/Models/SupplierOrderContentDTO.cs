namespace Negosud.webapi.Models
{
    public class SupplierOrderContentDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float BeforePriceTax { get; set; }
        public float VAT { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
        public int CommandSupplierId { get; set; }
        public CommandSupplierDTO CommandSupplier { get; set; }
    }
}
