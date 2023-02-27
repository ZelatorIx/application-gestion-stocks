namespace Negosud.MVCWeb.Services.Model.Types
{
    public interface ModelSupplierOrderContent
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public float BeforePriceTax { get; set; }
        public float VAT { get; set; }
        public int ItemId { get; set; }
        public ModelItem Item { get; set; }
        public int CommandSupplierId { get; set; }
        public ModelCommandSupplier CommandSupplier { get; set; }
    }
}
