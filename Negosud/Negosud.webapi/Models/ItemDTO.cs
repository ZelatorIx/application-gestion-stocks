namespace Negosud.webapi.Models
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = ""; 
        public float PurchasePriceBT { get; set; }
        public float SellingPriceBT { get; set; }
        public float Vat { get; set; }
        public string Picture { get; set; } = "";
        public int MinLimit { get; set; }
        public int YearItem { get; set; }
        public FamilyDTO Family { get; set; } = new FamilyDTO();
        public List<StockMovementDTO>? StockMovements { get; set; }
        public List<SupplierOrderContentDTO>? SupplierOrderContents { get; set; }
        public List<CustomerOrderContentDTO>? CustomerOrderContents { get; set; }
    }
}