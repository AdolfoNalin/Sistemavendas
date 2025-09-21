using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnNext_click
        private void btnNext_Click(object sender, EventArgs e)
        {
            string hash = PasswordGenerator.Generator(txtPassword.Text);
            
            
        }
        #endregion
    }
}
