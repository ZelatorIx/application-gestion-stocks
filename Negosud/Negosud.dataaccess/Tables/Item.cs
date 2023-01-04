using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        [Required]
        public float PurchasePriceBT { get; set; }
        [Required]
        public float SellingPriceBT { get; set; }
        [Required]
        public float Vat { get; set; }
        public string Picture { get; set; } = "";
        [Required]
        public int MinLimit { get; set; }
        [Required]
        public int YearItem { get; set; }
        public int FamilyId { get; set; }
        public Family Family { get; set; }
        public List<StockMovement>? StockMovements { get; set; }
        public List<CustomerOrderContent>? CustomerOrderContents { get; set; }
        public List<SupplierOrderContent>? SupplierOrderContents { get; set; }
    }
}