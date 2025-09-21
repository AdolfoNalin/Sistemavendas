using SistemaVenda.Service;
using SistemaVenda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        #region Load
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee screem = new frmEmployee();
            screem.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier screen = new frmSupplier();
            screen.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct screen = new frmProduct();
            screen.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSale screen = new frmSale();
            screen.ShowDialog();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void devoluçãoDeItensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItemReturn screen= new frmItemReturn();
            screen.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser screen = new frmUser();
            screen.ShowDialog();
        }
    }
}