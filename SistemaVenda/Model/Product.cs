using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Product : ProductShoppingCar
    {
        #region Campos
        /// <summary>
        /// Campos da classe Produtos
        /// </summary>
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public string FullDescription { get; set; }
        public decimal EntryPrice { get;  set; }
        public string UniMeasure { get; set; }
        public DateTime Date { get; set; }
        #endregion
    }
}
