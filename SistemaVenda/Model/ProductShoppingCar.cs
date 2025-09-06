using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class ProductShoppingCar
    {
        #region Campos
        /// <summary>
        /// Campos da classe Produtos
        /// </summary>
        public string ShortDescription { get; set; }
        public decimal CashPrice { get; set; }
        public decimal TermPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public double Amount { get; set; }
        #endregion
    }
}
