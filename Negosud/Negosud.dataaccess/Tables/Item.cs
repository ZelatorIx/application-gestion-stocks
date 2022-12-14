namespace Negosud.dataaccess.Tables
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = ""; 
        public float PurchasePriceBT { get; set; }
        public float SellingPriceBT { get; set; }
        public float Vat { get; set; }
        public string Image { get; set; } = "";
        public int MinLimit { get; set; } 
        public int YearItem { get; set; }

    }
}