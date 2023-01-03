namespace Negosud.webapi.Models
{
    public class CommandSupplierDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
        public SupplierDTO Supplier { get; set; }
        public List<SupplierOrderContentDTO>? SupplierOrderContents { get; set; }
    }
}
