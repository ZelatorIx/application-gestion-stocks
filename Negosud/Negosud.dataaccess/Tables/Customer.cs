using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Tables
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Phone { get; set; }
        public string PhysicalAddress { get; set; } = "";
        public string ComplementaryAddress { get; set; } = "";
        public int PostalCode { get; set; }
        public string Town { get; set; } = "";
        public string ElectronicAddress { get; set; } = "";
        public Item[]? Items { get; set; }
    }
}
