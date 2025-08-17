using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Employee : Client
    {
        public string Function { get; set; }
        public List<String> Authorizations { get; set; }
    }
}
