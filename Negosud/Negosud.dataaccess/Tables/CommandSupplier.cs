using Negosud.dataaccess.Interfaces;

namespace Negosud.dataaccess.Tables
{
    public class CommandSupplier : ICommand
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
        public Supplier[]? Suppliers{ get; set; }
        public SupplierOrderContent[]? SupplierOrderContents { get; set; }
    }
}
