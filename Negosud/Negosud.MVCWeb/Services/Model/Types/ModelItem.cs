using System.ComponentModel.DataAnnotations;

namespace Negosud.MVCWeb.Services.Model.Types
{
    public interface ModelItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float PurchasePriceBT { get; set; }
        public float SellingPriceBT { get; set; }
        public float Vat { get; set; }
        public string Picture { get; set; }
        public int MinLimit { get; set; }
        public int YearItem { get; set; }
        public int FamilyId { get; set; }
        public ModelFamily Family { get; set; }
        public List<ModelStockMovement> StockMovements { get; set; }
        public List<ModelCustomerOrderContent> CustomerOrderContents { get; set; }
        public List<ModelSupplierOrderContent> SupplierOrderContents { get; set; }
    }
}
