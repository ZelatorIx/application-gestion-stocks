using System.ComponentModel.DataAnnotations;

namespace Negosud.MVCWeb.Services.Model.Types
{
    public interface ModelStockMovement
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public ModelItem Item { get; set; }
        public int RegularizationId { get; set; }
        public ModelRegularization Regularization { get; set; }
    }
}
