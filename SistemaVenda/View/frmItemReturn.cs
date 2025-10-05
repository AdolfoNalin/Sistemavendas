using SistemaVenda.br.pro.com.model;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmItemReturn : Form
    {
        public frmItemReturn()
        {
            InitializeComponent();
        }

        #region UpdateData
        private async void UpdateData()
        {
            dgItemReturn.DataSource = await ItemReturnService.Get();
        }
        #endregion

        #region UpdateDetails
        #endregion
    }
}
