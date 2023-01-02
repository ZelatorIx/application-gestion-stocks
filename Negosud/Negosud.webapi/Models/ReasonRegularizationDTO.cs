using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Tables
{
    public class ReasonRegularizationDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool Sense { get; set; }
    }
}
