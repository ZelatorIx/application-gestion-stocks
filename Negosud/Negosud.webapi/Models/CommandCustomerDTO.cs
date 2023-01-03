namespace Negosud.webapi.Models
{
    public class CommandCustomerDTO
    {
        public int Id { get; set; }
        public int Number { get; set; } 
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
        public CustomerDTO Customer { get; set; }
        public List<CustomerOrderContentDTO>? CustomerOrderContents { get; set; }
    }
}
