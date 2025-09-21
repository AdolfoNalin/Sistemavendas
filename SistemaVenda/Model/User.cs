using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class User : UserResquest
    {
        #region Campos
        /// <summary>
        /// Atributos da classe do obj
        /// </summary>
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public List<string> Authorizations { get; set; }
        #endregion
    }
}
