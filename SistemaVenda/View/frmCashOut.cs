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
    public partial class frmCashOut : Form
    {
        public frmCashOut()
        {
            InitializeComponent();
        }

        #region btnNext_Click
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
