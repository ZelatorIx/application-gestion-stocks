using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Tables
{
    public class RegularizationDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Inventorist { get; set; } = "";
    }
}
