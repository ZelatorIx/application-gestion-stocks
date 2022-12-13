namespace Negosud.dataaccess.Tables
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public int Code { get; set; }
        public int Quantity { get; set; }
        public string? Image { get; set;  }
        public Family? Family { get; set; }
        public int Year { get; set; }
        public Customer[]? Clients { get; set; }
        public Supplier[]? Suppliers { get; set; }
    }
}