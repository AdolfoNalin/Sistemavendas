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
using System.Net.Sockets;
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
        decimal subtotalVista = 0;
        decimal subtotalPrazo= 0;
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
            frmConsultarClienteOrcmento tela = new frmConsultarClienteOrcmento();
            tela.ShowDialog();

            int idCliente = int.Parse(tela.dgCOC.CurrentRow.Cells[0].Value.ToString());

            ClienteDAO dao = new ClienteDAO();

            obj = dao.BuscarClienteId(idCliente);
            txtNome.Text = obj.Nome;
            mtbCPF.Text = obj.CPF;
            mtbFone.Text = obj.Celular;
            txtEndereco.Text = $"{obj.Cidade}, {obj.Bairro}, {obj.Logradouro}, {obj.Numero}, {obj.Complemento}";
            txtID.Text = obj.Codigo.ToString();
        }
        #endregion

        #region ConsultaProduto
        private void button2_Click(object sender, EventArgs e)
        {
            frmConsultarProdutoOV cp = new frmConsultarProdutoOV();
            cp.ShowDialog();

            int idProduto = int.Parse(cp.dgCPOV.CurrentRow.Cells[0].Value.ToString());

            Produto produto = new Produto();
            ProdutoDAO dao = new ProdutoDAO();
            produto = dao.BuscarProdutoVenda(idProduto);

            txtCodigoProduto.Text = produto.Codigo.ToString();
            txtDescricaoResumida.Text = produto.DescricaoResumida;
            txtEstoque.Text = dao.RetornarEstoque(idProduto).ToString();
            txtPrecoVista.Text = produto.PrecoVista.ToString();
            txtPrecoPrazo.Text = produto.PrecoPrazo.ToString();
            txtQuantidade.Focus();
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

        #region PesquisarProduto
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
            else if(rbtnVista.Checked)
            {
                try
                {
                    quantidade = int.Parse(txtQuantidade.Text);
                    precoVista = decimal.Parse(txtPrecoVista.Text);
                    descontoPorcentagem = decimal.Parse(mtbDescontoPorcentagem.Text);
                    descontoReal = decimal.Parse(mtbDescontoReal.Text);

                    quantidadeTotal += quantidade;
                    lblQuantidadePrutudoQ.Text = quantidadeTotal.ToString();


                    subtotalVista = precoVista * quantidade;

                    total += subtotalVista;

                    mtbTotal.Text = total.ToString();

                    dgCarrinho.Rows.Add(Convert.ToInt16(txtCodigoProduto.Text), txtDescricaoResumida.Text, quantidade, precoVista, subtotalVista);

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
                    throw;
                }
            }
            else
            {
                try
                {
                    quantidade = int.Parse(txtQuantidade.Text);
                    precoPrazo = decimal.Parse(txtPrecoPrazo.Text);
                    descontoPorcentagem = decimal.Parse(mtbDescontoPorcentagem.Text);
                    descontoReal = decimal.Parse(mtbDescontoReal.Text);

                    quantidadeTotal += quantidade;
                    lblQuantidadePrutudoQ.Text = quantidadeTotal.ToString();


                    subtotalPrazo = precoPrazo* quantidade;

                    dgCarrinho.Rows.Add(Convert.ToInt16(txtCodigoProduto.Text), txtDescricaoResumida.Text, quantidade, precoPrazo, subtotalPrazo);

                    total += subtotalPrazo;
                    mtbTotal.Text = total.ToString();
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
                    throw;
                }
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
                subtotalVista = 0;
                foreach(DataGridViewRow linha in dgCarrinho.Rows)
                {
                    Produto produto = new ProdutoDAO().ConsultarProdutoNome(int.Parse(linha.Cells[0].Value.ToString())); 
                    int quantidade = int.Parse(linha.Cells[2].Value.ToString());
                    decimal valorVista = produto.PrecoVista;

                    linha.Cells[4].Value = quantidade * valorVista;
                    linha.Cells[3].Value = valorVista;
                    subtotalVista += Decimal.Parse(linha.Cells[4].Value.ToString());
                }
                total = subtotalVista;
                mtbTotal.Text = total.ToString();
            }
        }
        #endregion

        #region rbtnPrazoCheck
        private void rbtnPrazo_CheckedChanged(object sender, EventArgs e)
        {
            subtotalPrazo = 0;  
            if (rbtnPrazo.Checked && dgCarrinho.Rows.Count > 0)
            {
                foreach(DataGridViewRow linha in dgCarrinho.Rows)
                {
                    Produto produto = new ProdutoDAO().ConsultarProdutoNome(int.Parse(linha.Cells[0].Value.ToString()));
                    decimal valorPrazo = produto.PrecoPrazo;
                    int quantidade = int.Parse(linha.Cells[2].Value.ToString());

                    linha.Cells[4].Value = quantidade * valorPrazo;
                    linha.Cells[3].Value = valorPrazo;
                    subtotalPrazo += Decimal.Parse(linha.Cells[4].Value.ToString());
                }
                total = subtotalPrazo;
                mtbTotal.Text = total.ToString();
            }
        }
        #endregion

    }
}
