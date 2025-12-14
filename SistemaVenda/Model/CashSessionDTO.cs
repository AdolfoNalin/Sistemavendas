using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class CashSessionDTO
    {
        public Guid Id { get; set; }
        public string UserName{ get; set; }
        public DateTime Date { get; set; }
        public decimal OpeningAmount { get; set; }
        public Enable Enable { get; set; }
        public IsCashSession Status { get; set; }
        public decimal Total { get; set; }
    }
}
