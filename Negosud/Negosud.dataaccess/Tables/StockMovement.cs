using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class StockMovement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Item[]? Items { get; set; }
        public Regularization[]? Regularizations { get; set; }
    }
}
