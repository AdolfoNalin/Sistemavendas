using SistemaVenda.Service;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVenda.Model;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmBudget : Form
    {
        public frmBudget()
        {
            InitializeComponent();
        }

        private void frmBudget_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        #region UpdateData
        private void UpdateData()
        {
            dgBudget.DataSource = BudgetService.Get();
        }
        #endregion

        #region UpdateDetails
        private void UpdateDatails()
        {
            if(dgBudget.Rows.Count > 0)
            {
                Budget obj = (Budget)dgBudget.SelectedRows[0].DataBoundItem;


            }
        }
        #endregion

        #region btnConsultClient
        private void btnConsultClient_Click(object sender, EventArgs e)
        {
            frmClient screen = new frmClient();
            Client client = (Client)screen.dgClient.SelectedRows[0].DataBoundItem;
            txtNome.Text = client.Name;
            screen.Hide();
        }
        #endregion
    }
}
