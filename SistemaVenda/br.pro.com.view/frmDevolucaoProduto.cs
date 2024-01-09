using SistemaVenda.br.pro.com.dao;
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
    public partial class frmDevolucaoProduto : Form
    {
        public frmDevolucaoProduto()
        {
            InitializeComponent();
        }

        #region btnCliente
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmConsultarCliente cliente = new frmConsultarCliente();
            this.Hide();
            cliente.ShowDialog();
        }
        #endregion

        #region Load
        private void frmDevolucaoProduto_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            cbCliente.DataSource = dao.ConsultarClientes();
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";
        }
        #endregion

        #region ConsultaVendaID
        private void txtCodigoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int id = int.Parse(txtCodigoVenda.Text);

                ItemVendaDAO dao = new ItemVendaDAO();
                dgDevolucao.DataSource = dao.ListarItemVenda(id);
            }    
        }
        #endregion

        #region btnSalvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDAO dao  = new ProdutoDAO();
                
                for (int i = 0; i < dgDevolucao.Rows.Count; i++)
                {
                    int quantidade = int.Parse(dgDevolucao.CurrentRow.Cells[2].Value.ToString());
                    int codigo = int.Parse(dgDevolucao.CurrentRow.Cells[0].Value.ToString());

                    dao.ControlarEstoque(codigo, quantidade);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
            }
        }
        #endregion
    }
}
