using Negosud.dataaccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.dataaccess.Tables
{
    public class CommandCustomer : ICommand
    {
        public int Id { get; set; }
        public int Number { get; set; } 
        public DateTime Date { get; set; }
        public string Status { get; set; } = "";
    }
}
