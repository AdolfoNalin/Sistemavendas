using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public enum Enable
    {
        Enable,
        Disabel
    }

    public enum IsCashSession
    {
        Close,
        Open
    }
    public class CashSession
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal OpeningAmount{ get; set; }
        public Enable Enable { get; set; }
        public IsCashSession Status { get; set; }
        public decimal Total { get; set; }
    }
}
