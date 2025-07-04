    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Budget
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ProductId { get; set; }
        public decimal DescountPercentage { get; set; }
        public decimal CashDescount { get; set; }
        public decimal AdditionPorcentage{ get; set; }
        public decimal AdditionCash { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Changes{ get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int AmountItens { get; set; }
        public string Obs { get; set; }
    }
}
