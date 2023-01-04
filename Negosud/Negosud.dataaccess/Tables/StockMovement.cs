using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class StockMovement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int RegularizationId { get; set; }
        public Regularization Regularization { get; set; }
    }
}
