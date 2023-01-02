namespace Negosud.dataaccess.Tables
{
    public class StockMovement
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Item[]? Items { get; set; }
        public Regularization[]? Regularizations { get; set; }
    }
}
