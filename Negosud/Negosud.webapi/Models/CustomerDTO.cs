namespace Negosud.webapi.Models
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public int PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; } = "";
        public int PostalCode { get; set; }
        public string Town { get; set; } = "";
        public ItemDTO[]? Items { get; set; }
    }
}
