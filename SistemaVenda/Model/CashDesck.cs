using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class CashDesck
    {
        public static Guid Id { get; set; }
        public static Guid UserId { get; set; }
        public static DateTime Date { get; set; }
        public static decimal OpeningAmount { get; set; }
        public static Enable Enable { get; set; }
        public static IsCashSession Status { get; set; }
        public static decimal Total { get; set; }
    }
}
