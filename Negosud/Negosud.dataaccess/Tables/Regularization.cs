using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class Regularization
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Inventorist { get; set; } = "";
        [Required]
        public ReasonRegularization ReasonRegularization { get; set; } = new ReasonRegularization();
        public StockMovement[]? StockMovements { get; set; }
    }
}
