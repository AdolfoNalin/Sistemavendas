using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Orcamento
    {
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoVendedor { get; set; }
        public int CodigoProduto { get; set; }
        public decimal DescontoPorcentagem { get; set; }
        public decimal DescontoReal { get; set; }
        public decimal AcrescimoPorcentagem{ get; set; }
        public decimal AcrescimoReal { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Alteracoes{ get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public int QuantidadeTotal { get; set; }
        public string Obs { get; set; }
    }
}
