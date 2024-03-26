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
    public partial class frmConsultarProdutoOV : Form
    {
        public frmConsultarProdutoOV()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultarProdutoOV_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dgCPOV.DataSource = dao.ConsultarProdutos();
        }
        #endregion

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = '%' + txtNome.Text + '%';

            ClienteDAO clienteDao = new ClienteDAO();
            dgCPOV.DataSource = clienteDao.ListarClienteNome(nome);

            if (dgCPOV.Rows.Count == 0 || txtNome.Text == String.Empty)
            {
                dgCPOV.DataSource = clienteDao.ConsultarClientes();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dgCPOV.DataSource = dao.BuscarProduto(txtNome.Text);
        }

        private void dgCPOV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
        }
    }
}
