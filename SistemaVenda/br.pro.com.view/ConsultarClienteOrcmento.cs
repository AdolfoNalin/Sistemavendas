using SistemaVenda.br.pro.com.dao;
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

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmConsultarClienteOrcmento : Form
    {
        public frmConsultarClienteOrcmento()
        {
            InitializeComponent();
        }

        #region txtNome
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ClienteDAO obj = new ClienteDAO();
                dgCOC.DataSource = obj.ListarClienteNome(txtNome.Text);
            }
        }
        #endregion

        private void frmConsultarClienteOrcmento_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgCOC.DataSource = dao.ConsultarClientes();
        }

        #region dgCOC_CellClick
        private void dgCOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
