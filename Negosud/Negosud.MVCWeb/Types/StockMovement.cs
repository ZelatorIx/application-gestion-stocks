using System.ComponentModel.DataAnnotations;

namespace Negosud.MVCWeb.Types
{
    public interface StockMovement
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int RegularizationId { get; set; }
        public Regularization Regularization { get; set; }
    }
}
