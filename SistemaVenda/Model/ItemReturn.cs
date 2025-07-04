using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class ItemReturn
    {
        public Guid Id { get; set; }
        public Guid IdSale { get; set; }
        public Guid IdClient{ get; set; }
        public Guid IdProduct { get; set; }
        public double Amount { get; set; }
        public string Reason { get; set; }
        public decimal Total { get; set; }
        public string Obs { get; set; }
    }
}
