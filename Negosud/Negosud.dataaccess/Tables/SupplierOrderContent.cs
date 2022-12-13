using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Tables
{
    public class SupplierOrderContent
    {
        public int Quantity { get; set; }
        public float BeforePriceTax { get; set; }
        public float Vat { get; set; }

    }
}
