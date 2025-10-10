using Org.BouncyCastle.Asn1;
using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class ItemReturn : AItem
    {
        #region Campos
        public Guid ReturnId { get; set; }
        public Guid ProductId { get; set; }
        #endregion
    }
}
