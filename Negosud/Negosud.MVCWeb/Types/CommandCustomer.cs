namespace Negosud.MVCWeb.Types
{
    public class CommandCustomer
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<CustomerOrderContent>? CustomerOrderContents { get; set; }
    }
}
