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
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
        }

        #region dgProduto_KeyPress
        /// <summary>
        /// Evento que pega os dados do obj e passa para o tabCadastrarProduto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgProduto_DoubleClick(object sender, EventArgs e)
        {
            frmCadastrarProduto cp = new frmCadastrarProduto();

            cp.txtCodigo.Text = dgProduto.CurrentRow.Cells[0].Value.ToString();
            cp.txtDescricaoResumida.Text = dgProduto.CurrentRow.Cells[1].Value.ToString();
            cp.txtDescricaoCompleta.Text = dgProduto.CurrentRow.Cells[2].Value.ToString();
            cp.txtPrecoVista.Text = dgProduto.CurrentRow.Cells[3].Value.ToString();
            cp.txtPrecoPrazo.Text = dgProduto.CurrentRow.Cells[4].Value.ToString();
            cp.txtValorEntrada.Text = dgProduto.CurrentRow.Cells[5].Value.ToString();
            cp.txtValorTotal.Text = dgProduto.CurrentRow.Cells[6].Value.ToString();
            cp.txtQuantidade.Text = dgProduto.CurrentRow.Cells[7].Value.ToString();
            cp.cbUniMedida.Text = dgProduto.CurrentRow.Cells[8].Value.ToString();
            cp.mtbData.Text = dgProduto.CurrentRow.Cells[9].Value.ToString();
            cp.mtbHora.Text = dgProduto.CurrentRow.Cells[10].Value.ToString();
            cp.cbFornecedor.Text = dgProduto.CurrentRow.Cells[11].Value.ToString();
            
            cp.ShowDialog();
        }
        #endregion

        #region txtNome_KeyPress
        /// <summary>
        /// Evento que atualiza os dados que são digitados pelo usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string descricao = "%" + txtNome.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();
            dgProduto.DataSource = dao.ListarProdutoNome(descricao);

            if (dgProduto.Rows.Count == 0 || txtNome.Text == String.Empty)
            {
                dgProduto.DataSource = dao.ConsultarProdutos();
            }
        }
        #endregion

        #region Load
        private void frmConsultarProduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO obj = new ProdutoDAO();
            dgProduto.DataSource = obj.ConsultarProdutos();
        }
        #endregion

        #region btnPesquisar_Click
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            dgProduto.DataSource = dao.BuscarProduto(txtNome.Text);
        }
        #endregion
    }
}
