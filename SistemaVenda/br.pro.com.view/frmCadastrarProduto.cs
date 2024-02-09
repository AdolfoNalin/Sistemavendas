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
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        frmConsultarProduto telaProduto = new frmConsultarProduto();

        #region Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            mtbData.Text = String.Format(DateTime.Now.ToShortDateString(), "dd/mm/yyyy");
            mtbHora.Text = String.Format(DateTime.Now.ToShortTimeString(), "h:mm");

            FornecedorDAO obj = new FornecedorDAO();
            cbFornecedor.DataSource = obj.ConsultarFornecedores();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

        }
        #endregion

        #region Salvar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                DescricaoCompleta = txtDescricaoCompleta.Text,
                DescricaoResumida = txtDescricaoResumida.Text,
                PrecoVista = Convert.ToDecimal(txtPrecoVista.Text),
                PrecoPrazo = Convert.ToDecimal(txtPrecoPrazo.Text),
                ValorEntrada = Convert.ToDecimal(txtValorEntrada.Text),
                ValorTotal = Convert.ToDecimal(txtValorTotal.Text),
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                UniMedida = cbUniMedida.Text,
                Data = Convert.ToDateTime(mtbData.Text),
                Hora = Convert.ToDateTime(mtbHora.Text),
                CodigoFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString())
            };

            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProdutos(obj);

            new Helpers().LimparTela(this);
            telaProduto.dgProduto.DataSource = dao.ConsultarProdutos();
        }
        #endregion

        #region btnKLimpar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this); 
        }
        #endregion

        #region Editar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto()
            {
                Codigo = int.Parse(txtCodigo.Text),
                DescricaoCompleta = txtDescricaoCompleta.Text,
                DescricaoResumida = txtDescricaoResumida.Text,
                PrecoVista = Convert.ToDecimal(txtPrecoVista.Text),
                PrecoPrazo = Convert.ToDecimal(txtPrecoPrazo.Text),
                ValorEntrada = Convert.ToDecimal(txtValorEntrada.Text),
                ValorTotal = Convert.ToDecimal(txtValorTotal.Text),
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                UniMedida = cbUniMedida.Text,
                Data = Convert.ToDateTime(mtbData.Text),
                Hora = Convert.ToDateTime(mtbHora.Text),
                CodigoFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString())
            };

            ProdutoDAO dao = new ProdutoDAO();
            dao.EditarProduto(obj);

            new Helpers().LimparTela(this);

            telaProduto.dgProduto.DataSource = dao.ConsultarProdutos();
        }
        #endregion

        #region Excluir
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.Codigo = int.Parse(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProduto(obj);

            telaProduto.dgProduto.DataSource = dao.ConsultarProdutos();

            new Helpers().LimparTela(this);
        }
        #endregion

        #region txtPrecoAvista_KeyPress
        private void txtPrecoVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal valorVista = Decimal.Parse(txtPrecoVista.Text);
                int quantidade = int.Parse(txtQuantidade.Text);

                decimal result = valorVista * quantidade;
                txtValorTotal.Text = result.ToString();
            }
        }
        #endregion
    }
}
