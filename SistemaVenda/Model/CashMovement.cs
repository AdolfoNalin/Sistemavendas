using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public enum Type
    {
        Entry,
        Exit
    }

    public class CashMovement
    {
        public Guid Id { get; set; }
        public Guid CashSessionId { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public Type Type { get; set; } 
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
