namespace Negosud.webapi.Models
{
    public class StockMovementDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public List<ItemDTO>? Items { get; set; }
        public List<RegularizationDTO>? Regularizations { get; set; }
    }
}
