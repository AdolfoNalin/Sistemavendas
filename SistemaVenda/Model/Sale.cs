using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
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
        public string PaymentMethod{ get; set; }
        public decimal PercentageDiscount{ get; set; }
        public decimal CashDiscount{ get; set; }
        public decimal AdditionPorcentage{ get; set; }
        public decimal AdditionCash{ get; set; }
        public decimal Total{ get; set; }
        public string Observation { get; set; }
        #endregion
    }
}
