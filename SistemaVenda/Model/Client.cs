using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class Client : Persona
    {
        public string ShortName { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string MaritalStatus { get; set; }
        public decimal Credit { get; set; }
    }
}
