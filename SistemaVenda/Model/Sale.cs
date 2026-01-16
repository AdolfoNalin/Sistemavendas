using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public enum OpenOrClose
    {
        Open,
        Close
    }
    public class Sale
    {
        #region Campos da classe
        /// <summary>
        /// Campos da calsse
        /// </summary>
        public Guid Id { get; set; }
        public Guid CashId { get; set; }
        public Guid ClientId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PaymentMethod{ get; set; }
        public decimal PercentageDiscount{ get; set; }
        public decimal CashDiscount{ get; set; }
        public decimal AdditionPorcentage{ get; set; }
        public decimal AdditionCash{ get; set; }
        public decimal Total{ get; set; }
        public string Observation { get; set; }
        public OpenOrClose Open { get; set; }

        public Client Client { get; set; }
        public Employee Employee { get; set; }
        #endregion
    }
}
