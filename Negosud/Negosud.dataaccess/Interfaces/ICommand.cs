using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Interfaces
{
    public interface ICommand
    {
        int Number { get; set; }
        DateTime Date { get; set; }
        string Status { get; set; }
    }
}
