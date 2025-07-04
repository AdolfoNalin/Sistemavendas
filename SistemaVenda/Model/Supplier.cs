using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Supplier : Client
    {
        #region Campos
        /// <summary>
        /// Campos da classe
        /// </summary>
        public string CNPJ { get; set; }
        #endregion
    }
}
