using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class SaleDTO
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Total { get; set; }
        public string Observation { get; set; }
    }
}
