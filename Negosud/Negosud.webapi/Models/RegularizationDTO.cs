namespace Negosud.webapi.Models
{
    public class RegularizationDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Inventorist { get; set; } = "";
        public ReasonRegularizationDTO ReasonRegularization { get; set; }
        public List<StockMovementDTO>? StockMovements { get; set; }
    }
}
