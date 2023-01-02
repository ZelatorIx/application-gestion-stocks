using Negosud.dataaccess.Interfaces;

namespace Negosud.dataaccess.Tables
{
    public class CommandCustomer : ICommand
    {
        public int Id { get; set; }
        public int Number { get; set; } 
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
        public Customer[]? Customers { get; set; }
        public CustomerOrderContent[]? CustomerOrderContents { get; set; }
    }
}
