using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Product
    {
        #region Campos
        /// <summary>
        /// Campos da classe Produtos
        /// </summary>
        public Guid Id { get; set; }
        public int SupplierId { get; set; }
        public string FullDescription { get; set; }
        public string ShortDescription { get; set; }
        public decimal CashPrice { get;set; }
        public decimal TermPrice { get;set; }
        public decimal EntryPrice { get;  set; }
        public decimal TotalPrice { get; set; }
        public int Amount { get; set; }
        public int UniMeasure { get; set; }
        public DateTime Data { get; set; }
        #endregion
    }
}
