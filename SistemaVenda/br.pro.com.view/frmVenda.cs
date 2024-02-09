using iTextSharp.text.pdf.codec;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Digests;
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
            

            if (dgCarrinho.Columns.Count == 0)
            {
                dgCarrinho.Columns.Add("codigo", "Código");
                dgCarrinho.Columns.Add("produto", "Produto");
                dgCarrinho.Columns.Add("quantidade", "Quantidade");
                dgCarrinho.Columns.Add("preco", "Preço");
                dgCarrinho.Columns.Add("subtotal", "SubTotal");

                mtbTotal.Text = String.Format("{0:0.00}", num);
                mtbDescontoPorcentagem.Text = String.Format("{0:0.00}", num);
                mtbDescontoReal.Text = String.Format("{0:0.00}", num);
                mtbAgrescimoD.Text = String.Format("{0:0.00}", num);
                mtbAgrescimoP.Text = String.Format("{0:0.00}", num);
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
            txtEndereco.Text = $"{obj.Cidade}, {obj.Bairro},{obj.Logradouro}, {obj.Numero}";
        }
        #endregion

        #region PesquisarProdutoKeyPress13
        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            { 
                MessageBox.Show("Código do produto não encontrado!");
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

            if (rbtnPrazo.Checked == false && rbtnVista.Checked == false)
            {
                MessageBox.Show("Por favor, marque a forma de pagamento!", "ATENÇÃO", MessageBoxButtons.OK);
            }

            try
            {
                quantidade = int.Parse(txtQuantidade.Text);
                precoVista = decimal.Parse(txtPrecoVista.Text);
                precoPrazo = decimal.Parse(txtPrecoPrazo.Text);
                descontoPorcentagem = decimal.Parse(mtbDescontoPorcentagem.Text);
                descontoReal = decimal.Parse(mtbDescontoReal.Text);

                subtotalProduto = precoVista * quantidade;
                quantidadeTotal += quantidade;
                lblQuantidadePrutudoQ.Text = quantidadeTotal.ToString();


                subtotal = precoVista * quantidade;

                total += subtotal;

                mtbTotal.Text = total.ToString();
                
                dgCarrinho.Rows.Add(Convert.ToInt16(txtCodigoProduto.Text), txtDescricaoResumida.Text, quantidade, precoVista, subtotalProduto);

                txtCodigoProduto.Clear();
                txtDescricaoResumida.Clear();
                txtEstoque.Clear();
                txtQuantidade.Clear();
                txtPrecoPrazo.Clear();
                txtPrecoVista.Clear();

                txtCodigoProduto.Focus();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Por favor, certifique-se que todos os campos então preenchidos");
            }
            
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
            dgCarrinho.Rows.RemoveAt(indici);
        }
        #endregion

        #region btnPagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagamento pg = new frmPagamento(obj,dgCarrinho,cbVendedor.Text);
            pg.mtbTotal.Text = mtbTotal.Text;
            this.Hide();
            pg.ShowDialog();
        }
        #endregion

        #region AgrescimoProcentagem
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbAgrescimoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    decimal convert = Convert.ToDecimal(mtbAgrescimoP.Text);
                    decimal setResult = (convert * total) / 100;
                    total += setResult;
                    mtbTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region AgrescimoDinheiro
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbAgrescimoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (e.KeyChar == 13)
                    {
                        total += Convert.ToDecimal(mtbAgrescimoD.Text);
                        mtbTotal.Text = total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region rbtnVistaCheck
        private void rbtnVista_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnVista.Checked && dgCarrinho.Rows.Count > 0)
            {
                decimal subtotal = 0;
                foreach(DataGridViewRow linha in dgCarrinho.Rows)
                {
                    int quantidade = int.Parse(linha.Cells[2].Value.ToString());
                    decimal valorVista = Decimal.Parse(linha.Cells[3].Value.ToString());

                    linha.Cells[4].Value = quantidade * valorVista;
                    subtotal += Decimal.Parse(linha.Cells[4].Value.ToString());
                }
                total = subtotal;
                mtbTotal.Text = total.ToString();
            }
        }
        #endregion

        #region rbtnPrazoCheck
        private void rbtnPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrazo.Checked && dgCarrinho.Rows.Count > 0)
            {
                decimal sobtotal = 0;
                foreach(DataGridViewRow linha in dgCarrinho.Rows)
                {
                    decimal valorPrazo = Decimal.Parse(linha.Cells[3].Value.ToString());
                    int quantidade = int.Parse(linha.Cells[2].Value.ToString());

                    linha.Cells[4].Value = quantidade * valorPrazo;
                    subtotal += Decimal.Parse(linha.Cells[4].Value.ToString());
                }
            }
        }
        #endregion
    }
}
