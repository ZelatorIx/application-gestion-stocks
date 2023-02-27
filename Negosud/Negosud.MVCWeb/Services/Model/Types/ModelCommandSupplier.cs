using System.ComponentModel.DataAnnotations;

namespace Negosud.MVCWeb.Services.Model.Types
{
    public interface ModelCommandSupplier
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int SupplierId { get; set; }
        public ModelSupplier Supplier { get; set; }
        public List<ModelSupplierOrderContent> SupplierOrderContents { get; set; }
    }
}
