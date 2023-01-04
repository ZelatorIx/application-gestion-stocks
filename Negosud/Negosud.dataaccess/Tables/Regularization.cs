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
        public int ReasonRegularizationId { get; set; }
        public ReasonRegularization ReasonRegularization { get; set; }
        public List<StockMovement> StockMovements { get; set; }
    }
}
