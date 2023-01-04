namespace Negosud.webapi.Models
{
    public class StockMovementDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
        public int RegularizationId { get; set; }
        public RegularizationDTO Regularization { get; set; }
    }
}
