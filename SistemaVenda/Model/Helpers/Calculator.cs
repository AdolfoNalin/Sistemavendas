using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model.Helpers
{
    public class Calculator
    {
        #region AddingPorcentage
        public static Decimal Porcentage(decimal total, decimal value)
        {
            decimal result = (total * value) / 100;
            return result;
        }
        #endregion

        #region AddingCash
        public static Decimal Cash(decimal total, decimal value)
        {
            decimal result = (value / total) *100;
            return result;
        }
        #endregion
    }
}
