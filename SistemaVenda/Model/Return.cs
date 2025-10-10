using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class Return
    {
        public Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public Guid ClientId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}