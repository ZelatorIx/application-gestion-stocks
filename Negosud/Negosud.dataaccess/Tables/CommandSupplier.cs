using Negosud.dataaccess.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class CommandSupplier : ICommand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Status { get; set; } = "";
        [Required]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<SupplierOrderContent>? SupplierOrderContents { get; set; }
    }
}
