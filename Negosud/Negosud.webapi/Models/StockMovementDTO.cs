namespace Negosud.webapi.Models
{
    public class StockMovementDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public ItemDTO[]? Items { get; set; }
        public RegularizationDTO[]? Regularizations { get; set; }
    }
}
