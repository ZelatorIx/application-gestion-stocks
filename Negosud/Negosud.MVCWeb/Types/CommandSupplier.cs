using System.ComponentModel.DataAnnotations;

namespace Negosud.MVCWeb.Types
{
    public interface CommandSupplier
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<SupplierOrderContent> SupplierOrderContents { get; set; }
    }
}
