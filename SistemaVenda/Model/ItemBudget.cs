using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class ItemBudget : AItem
    {
        public Guid BudgetId{ get; set; }
        public Guid ProductId { get; set; }
    }
}
