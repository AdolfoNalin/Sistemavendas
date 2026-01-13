using SistemaVenda.Model;
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
            lblNome.Text = UserSession.Name;
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

        private void devoluçãoDeItensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReturn screen= new frmReturn();
            screen.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser screen = new frmUser();
            screen.ShowDialog();
        }

        private void trocaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword screem = new frmPassword();
            screem.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CashDesck.Status == IsCashSession.Close)
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user.User != null)
                {
                    DialogResult result = MessageBox.Show("Deseja mesmo sair do Sistema", "Atenção", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Para continuar com o desligamento do serviços. É necessário o fechamento do caixa");
            }
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCashSession screen = new frmCashSession();
            screen.ShowDialog();
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            frmBudget screen = new frmBudget();
            screen.ShowDialog();
        }

        private void movimentaçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountWriteOff screen = new frmAccountWriteOff();
            screen.ShowDialog();
        }
    }
}