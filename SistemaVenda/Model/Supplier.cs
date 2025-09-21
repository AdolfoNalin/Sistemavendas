using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Supplier : Persona
    {
        #region Campos
        /// <summary>
        /// Campos da classe
        /// </summary>
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        #endregion
    }
}
