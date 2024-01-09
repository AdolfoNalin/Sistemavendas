using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Devolucao
    {
        public int Codigo { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoCliente{ get; set; }
        public int CodigoProduto { get; set; }
        public double Quantidade { get; set; }
        public string Motivo { get; set; }
        public decimal Total { get; set; }
        public string Obs { get; set; }
    }
}
