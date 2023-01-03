using Negosud.dataaccess.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Negosud.dataaccess.Tables
{
    public class CommandCustomer : ICommand
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
        public Customer Customer { get; set; } = new Customer();
        public CustomerOrderContent[]? CustomerOrderContents { get; set; }
    }
}
