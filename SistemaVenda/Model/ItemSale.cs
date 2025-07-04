using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class ItemSale : AItem
    {
        #region Campos
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        #endregion
    }
}
