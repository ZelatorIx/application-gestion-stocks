namespace Negosud.dataaccess.Tables
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; } = "";
        public int PostalCode { get; set; }
        public string Town { get; set; } = "";
        public string Email { get; set; } = "";
        public Item[]? Items { get; set; }
    }
}
