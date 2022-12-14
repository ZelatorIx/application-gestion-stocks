using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Interfaces
{
    public interface IOrderContent
    {
        int Quantity { get; set; }
        float Price { get; set; }
        float VAT { get; set; }
    }
}
