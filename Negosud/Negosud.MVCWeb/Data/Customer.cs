﻿namespace Negosud.MVCWeb.Types
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string PhysicalAddress { get; set; } = "";
        public int PostalCode { get; set; }
        public string Town { get; set; } = "";
        public List<CommandCustomer>? CommandCustomers { get; set; }
    }
}
