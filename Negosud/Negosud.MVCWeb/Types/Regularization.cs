namespace Negosud.MVCWeb.Types
{
    public class Regularization
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Inventorist { get; set; } = "";
        public int ReasonRegularizationId { get; set; }
        public ReasonRegularization ReasonRegularization { get; set; }
        public List<StockMovement>? StockMovements { get; set; }
    }
}
