using Org.BouncyCastle.Asn1.Ocsp;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
using SistemaVenda.Model.Helpers;
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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        public UserResponse user = new UserResponse();

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnNext_click
        private async void btnNext_Click(object sender, EventArgs e)
        {
            user = await VerificationPassword.Verification(txtPassword.Text);
            if (user != null) 
            { 
                Hide();
            }
        }
        #endregion
    }
}
