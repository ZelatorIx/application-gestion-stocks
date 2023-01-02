namespace Negosud.webapi.Models
{
    public class CommandCustomerDTO
    {
        public int Id { get; set; }
        public int Number { get; set; } 
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
        public CustomerDTO[]? Customers { get; set; }
        public CustomerOrderContentDTO[]? CustomerOrderContents { get; set; }
    }
}
