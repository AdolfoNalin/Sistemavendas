using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class City
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string UF { get; set; }
        public string Neighborhood { get; set; }
        public string Complement {  get; set; }
        public string CEP { get; set; }
    }
}
