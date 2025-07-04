using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public abstract class AItem
    {
        #region Campos
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public decimal Subtotal { get; set; }
        #endregion
    }
}
