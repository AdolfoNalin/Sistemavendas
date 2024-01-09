using iTextSharp.text.pdf.codec;
using MySqlX.XDevAPI.Common;
using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.veiw
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent(); 
        }

        #region Variaveis da classe
        /// <summary>
        /// Variáveis de manipulação
        /// </summary>
        int quantidade = 0;
        int quantidadeTotal = 0;
        decimal precoVista = 0;
        decimal precoPrazo = 0;
        decimal subtotalProduto = 0;
        decimal subtotal = 0;
        decimal descontoPorcentagem = 0;
        decimal descontoReal = 0;
        decimal total = 0;
        #endregion

        #region Objs
        Cliente obj = new Cliente();    
        DataTable carrinho = new DataTable();
        #endregion

        #region Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVenda_Load(object sender, EventArgs e)
        {
            double num = 0.00;
            
            mtbTotal.Text = String.Format("{0:0.00}", num);
            mtbDescontoPorcentagem.Text = String.Format("{0:0.00}", num);
            mtbDescontoReal.Text = String.Format("{0:0.00}", num);

            if (dgCarrinho.Columns.Count == 0)
            {
                dgCarrinho.Columns.Add("codigo", "Código");
                dgCarrinho.Columns.Add("produto", "Produto");
                dgCarrinho.Columns.Add("quantidade", "Quantidade");
                dgCarrinho.Columns.Add("preco", "Preço");
                dgCarrinho.Columns.Add("subtotal", "SubTotal");
            }

            // Configuração da data
            mtbData.Text = DateTime.Now.ToShortDateString();
            mtbHora.Text = DateTime.Now.ToShortTimeString();

            mtbCPF.Focus();

            FuncionarioDAO dao = new FuncionarioDAO();
            cbVendedor.DataSource = dao.ConsultarFuncionario();
            cbVendedor.DisplayMember = "nome";
            cbVendedor.ValueMember = "id";
        }
        #endregion

        #region ConsultaCliente
        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultarCliente cc = new frmConsultarCliente();
            cc.ShowDialog();
        }
        #endregion

        #region ConsultaProduto
        private void button2_Click(object sender, EventArgs e)
        {
            frmConsultarProduto cp = new frmConsultarProduto();
            cp.ShowDialog();
        }
        #endregion

        #region btnPesquisarCliente
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            ClienteDAO cDao = new ClienteDAO();

            obj = cDao.BuscarClienteVendas(mtbCPF.Text);

            txtID.Text = obj.Codigo.ToString();
            txtNome.Text = obj.Nome;
            mtbFone.Text = obj.Celular;
            txtEndereco.Text = $"{obj.Estado}, {obj.Cidade}, {obj.Logradouro}, {obj.Numero}";
        }
        #endregion

        #region PesquisarProdutoKeyPress13
        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                Produto obj = new Produto();
                ProdutoDAO pDao = new ProdutoDAO();

                obj = pDao.BuscarProdutoVenda(int.Parse(txtCodigoProduto.Text));
                txtDescricaoResumida.Text = obj.DescricaoResumida;
                txtEstoque.Text = pDao.RetornarEstoque(int.Parse(txtCodigoProduto.Text)).ToString();
                txtPrecoVista.Text = obj.PrecoVista.ToString();
                txtPrecoPrazo.Text = obj.PrecoPrazo.ToString();
            }
            
        }
        #endregion

        #region CPF
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ClienteDAO dao = new ClienteDAO();

                obj = dao.BuscarClienteVendas(mtbCPF.Text);
                txtNome.Text = obj.Nome;
                mtbFone.Text = obj.Celular;
                txtEndereco.Text = $"{obj.Cidade}, {obj.Bairro}, {obj.Logradouro}, {obj.Numero}, {obj.Complemento}";
                txtID.Text = obj.Codigo.ToString();
            }
        }
        #endregion

        #region btnAdicionar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            quantidade = int.Parse(txtQuantidade.Text);
            precoVista = decimal.Parse(txtPrecoVista.Text);
            precoPrazo = decimal.Parse(txtPrecoPrazo.Text);
            descontoPorcentagem = decimal.Parse(mtbDescontoPorcentagem.Text);
            descontoReal = decimal.Parse(mtbDescontoReal.Text);

            subtotalProduto = precoVista * quantidade;
            quantidadeTotal += quantidade;
            lblQuantidadePrutudoQ.Text = quantidadeTotal.ToString();

            dgCarrinho.Rows.Add(Convert.ToInt16(txtCodigoProduto.Text), txtDescricaoResumida.Text, quantidade, precoVista, subtotalProduto);
            
            subtotal = precoVista * quantidade;

            total += subtotal;
            
            mtbTotal.Text = total.ToString();

            int estoque = Convert.ToInt16(txtEstoque.Text);
            int retirada = estoque - quantidade;

            Produto obj = new Produto();
            obj.Codigo = int.Parse(txtCodigoProduto.Text);
            obj.Quantidade = retirada;

            ProdutoDAO dao = new ProdutoDAO();
            dao.ControlarEstoque(obj.Codigo, obj.Quantidade);

            txtCodigoProduto.Clear();
            txtDescricaoResumida.Clear();
            txtEstoque.Clear();
            txtQuantidade.Clear();
            txtPrecoPrazo.Clear();
            txtPrecoVista.Clear();

            txtCodigoProduto.Focus();
        }
        #endregion

        #region DescontoReal
        private void mtbDescontoReal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                total -= Convert.ToDecimal(mtbDescontoReal.Text);
                mtbTotal.Text = total.ToString();
            }
        }
        #endregion

        #region DescontoPorcetnagem
        private void mtbDescontoPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal convert = Convert.ToDecimal(mtbDescontoPorcentagem.Text);
                decimal setResult = (convert * total) / 100;
                total -= setResult;
                mtbTotal.Text = total.ToString();
            }
        }
        #endregion

        #region btnRemover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            decimal subProduto = decimal.Parse(dgCarrinho.CurrentRow.Cells[4].Value.ToString());
            int indici = dgCarrinho.CurrentRow.Index;
            total -= subProduto;
            mtbTotal.Text = total.ToString();

            carrinho.Rows.RemoveAt(indici);
        }
        #endregion

        #region btnPagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagamento pg = new frmPagamento(obj,carrinho,dgCarrinho,cbVendedor.Text);
            pg.mtbTotal.Text = mtbTotal.Text;
            this.Hide();
            pg.ShowDialog();
        }
        #endregion

    }
}
