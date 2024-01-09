using Google.Protobuf.WellKnownTypes;
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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Security.Permissions;
using SistemaVenda.br.pro.com.veiw;
using iTextSharp.text.pdf.codec;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmCadastrarOrcamento : Form
    {

        #region Campos
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Produto Produto { get; set; }
        Orcamento obj = new Orcamento();

        int idOrcamento;

        decimal totalDD = 0;
        decimal totalDP = 0;
        decimal totalAD = 0;
        decimal totalAP = 0;
        #endregion

        #region Construtores
        public frmCadastrarOrcamento()
        {

            InitializeComponent();
        }
        #endregion

        #region Construtor ID
        public frmCadastrarOrcamento(int id)
        {
            this.idOrcamento = id;
        }
        #endregion

        #region CosntrutorCliente
        public frmCadastrarOrcamento(Cliente cliente)
        {
            
        }
        #endregion

        #region ConstrutorProduto
        public frmCadastrarOrcamento(Produto produto)
        {
            Produto.Codigo = produto.Codigo;
            Produto.DescricaoResumida = produto.DescricaoResumida;
            Produto.PrecoVista = produto.PrecoVista;
            Produto.PrecoPrazo = produto.PrecoPrazo;
            Produto.Quantidade = produto.Quantidade;
        }
        #endregion

        #region Variaveis
        int quantidadeP = 0;
        int quantidadeTotal = 0;
        decimal precoVista = 0;
        decimal precoPrazo = 0;
        decimal subtotalProduto = 0;
        decimal subtotalP = 0;
        decimal descontoPorcentagem = 0;
        decimal descontoReal = 0;
        decimal total = 0;
        #endregion

        #region Load
        private void frmCadastrarOrcamento_Load(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);

            decimal num = 0;
            
            mtbTotal.Text = String.Format("{0:0.00}", num);
            mtbSubTotal.Text = String.Format("{0:0.00}", num);
            mtbDD.Text = String.Format("{0:0.00}", num);
            mtbDP.Text = String.Format("{0:0.00}", num);
            mtbAteracoes.Text = String.Format("{0:0.00}", num);
            mtbAP.Text = String.Format("{0:0.00}", num);
            mtbAD.Text = String.Format("{0:0.00}", num);

            mtbData.Text = DateTime.Now.ToShortDateString();
            mtbHora.Text = DateTime.Now.ToShortTimeString();

            FuncionarioDAO dao = new FuncionarioDAO();
            ClienteDAO daoC = new ClienteDAO();

            if (txtCodigo.Text == String.Empty)
            { 

                cbVendedor.DataSource = dao.ConsultarFuncionario();
                cbCliente.DataSource = daoC.ConsultarClientes();

            }

            cbVendedor.DisplayMember = "nome";
            cbVendedor.ValueMember = "id";

            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";

            ProdutoDAO daoP = new ProdutoDAO();
            cbDescricao.DataSource = daoP.ConsutarProdutoOrcamento();
            cbDescricao.DisplayMember = "descricao_resumida";
            cbDescricao.ValueMember = "id";
   
        }
        #endregion

        #region Gravar
        public void Gravar()
        {
            try
            {
                ClienteDAO clienteDao = new ClienteDAO();
                FuncionarioDAO funcionarioDao = new FuncionarioDAO();

                Cliente = clienteDao.ListarNome(cbCliente.Text);
                Funcionario = funcionarioDao.ListarNome(cbVendedor.Text);

                quantidadeP = int.Parse(dgOrcamento.CurrentRow.Cells[2].Value.ToString());
                int quantidadeTotal = 0;

                quantidadeTotal += quantidadeP;

                Orcamento orcamento = new Orcamento();

                orcamento.CodigoCliente = Cliente.Codigo;
                orcamento.CodigoVendedor = Funcionario.Codigo;

                orcamento.DescontoPorcentagem = Decimal.Parse(mtbDP.Text);
                orcamento.DescontoReal = Decimal.Parse(mtbDD.Text);
                orcamento.AcrescimoPorcentagem = Decimal.Parse(mtbAP.Text);
                orcamento.AcrescimoReal = Decimal.Parse(mtbAP.Text);
                orcamento.SubTotal = Decimal.Parse(mtbSubTotal.Text);
                orcamento.Total = Decimal.Parse(mtbTotal.Text);
                orcamento.Alteracoes = Decimal.Parse(mtbAteracoes.Text);
                orcamento.Obs = txtObs.Text;
                orcamento.Data = DateTime.Parse(mtbData.Text);
                orcamento.Hora = DateTime.Parse(mtbHora.Text);
                orcamento.QuantidadeTotal = quantidadeTotal;

                OrcamentoDAO dao = new OrcamentoDAO();
                dao.CadastrarOrcamento(orcamento);

                for (int i = 1; i <= dgOrcamento.Rows.Count; i++)
                {
                    ItemOrcamento item = new ItemOrcamento();

                    item.CodigoOrcamento = dao.UltimoOrcamento();
                    item.CodigoProduto = int.Parse(dgOrcamento.CurrentRow.Cells[0].Value.ToString());
                    item.Quantidade = int.Parse(dgOrcamento.CurrentRow.Cells[2].Value.ToString());
                    item.Subtotal = Decimal.Parse(dgOrcamento.CurrentRow.Cells[4].Value.ToString());

                    ItemOrcamentoDAO itemDao = new ItemOrcamentoDAO();
                    itemDao.CadastrarItemOrcamento(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region btnGravar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion

        #region btnAdicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        { 
            ProdutoDAO dao = new ProdutoDAO();
            int idProduto = int.Parse(cbDescricao.SelectedValue.ToString());
            Produto obj = dao.ConsultarProdutoNome(idProduto);
            
            quantidadeP = int.Parse(txtQuantidade.Text);
            descontoPorcentagem = decimal.Parse(mtbDP.Text);
            descontoReal = decimal.Parse(mtbDD.Text);
            precoVista = obj.PrecoVista;
            precoPrazo = obj.PrecoPrazo;

            subtotalProduto = precoVista * quantidadeP;
            quantidadeTotal += quantidadeP;
            
            subtotalP = precoPrazo * quantidadeP;
            total += subtotalProduto;

            dgOrcamento.Rows.Add(obj.Codigo, cbDescricao.Text, quantidadeP, precoVista,precoPrazo, subtotalProduto);

            mtbSubTotal.Text = total.ToString();
            mtbTotal.Text = total.ToString();

            cbDescricao.Text = String.Empty;
            txtQuantidade.Clear();

            cbDescricao.Focus();
        }
        #endregion

        #region btnRemover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            decimal subProduto = decimal.Parse(dgOrcamento.CurrentRow.Cells[4].Value.ToString());
            int indici = dgOrcamento.CurrentRow.Index;
            total -= subProduto;
            mtbTotal.Text = total.ToString();

            dgOrcamento.Rows.RemoveAt(indici);
            MessageBox.Show(Convert.ToString(dgOrcamento.Rows.Count));

            if (dgOrcamento.Rows.Count == 0)
            {
                mtbDD.Clear();
                mtbDP.Clear();
                mtbAD.Clear();
                mtbAP.Clear();
                mtbSubTotal.Clear();
                mtbAteracoes.Clear();
                mtbTotal.Clear();
            }
        }
        #endregion

        #region btnEmprimir
        private void btnEmitir_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeArquivo = "";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    nomeArquivo = $"{filePath}_Orçamento.pdf";
                }

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\repos\SistemaVenda\Logo.jpeg");
                logo.ScaleToFit(150, 300);
                logo.SetAbsolutePosition(430f, 650f);

                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escrito = PdfWriter.GetInstance(doc, arquivoPDF);

                string dado = " ";

                Paragraph cabecario = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                //Dados da empresa
                cabecario.Alignment = Element.ALIGN_LEFT;
                cabecario.Add("Orçamento\nMaster Blocos e Lajes\nLuciane Pela Feijão: 46.594.384/0001-19\nEndereço: Rod SP 261 - Km 46,5\r\nBairro Jacutinga - zona rural \r\nÁguas de Santa Barbara\nContato: 14 99147 7975\nEmail: Luciani.pela@gmail.com");

                //Data e Hora
                Paragraph dataHora = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
                dataHora.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                dataHora.Alignment = Element.ALIGN_RIGHT;
                dataHora.Add($"\nData: {DateTime.Now.ToShortDateString()} Hora: {DateTime.Now.ToShortTimeString()}");

                //Dados do Orçamento
                Paragraph dadosOrcamento = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosOrcamento.Alignment = Element.ALIGN_LEFT;
                dadosOrcamento.Add($"Vendedor: {cbVendedor.Text} Cliente: {cbCliente.Text}");

                //Produtos
                Paragraph produtos = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                produtos.Alignment = Element.ALIGN_RIGHT;

                PdfPTable tabela = new PdfPTable(5);
                tabela.DefaultCell.FixedHeight = 20;

                tabela.AddCell("Código");
                tabela.AddCell("Produto");
                tabela.AddCell("Quantidade");
                tabela.AddCell("Preço");
                tabela.AddCell("SubTotal");

                int quantidade = 0;
                     
                for (int i = 0; i < dgOrcamento.Rows.Count; i++)
                {
                    Produto obj = new Produto();

                    obj.Codigo = int.Parse(dgOrcamento.CurrentRow.Cells[0].Value.ToString());
                    obj.DescricaoResumida = dgOrcamento.CurrentRow.Cells[1].Value.ToString();
                    obj.Quantidade = int.Parse(dgOrcamento.CurrentRow.Cells[2].Value.ToString());
                    obj.PrecoVista = Decimal.Parse(dgOrcamento.CurrentRow.Cells[3].Value.ToString());
                    obj.Subtotal = Decimal.Parse(dgOrcamento.CurrentRow.Cells[5].Value.ToString());

                    tabela.AddCell(obj.Codigo.ToString());
                    tabela.AddCell(obj.DescricaoResumida);
                    tabela.AddCell(obj.Quantidade.ToString());
                    tabela.AddCell(obj.PrecoVista.ToString());
                    tabela.AddCell(obj.Subtotal.ToString());

                    quantidade += obj.Quantidade;
                }

                tabela.HorizontalAlignment = Element.ALIGN_LEFT;

                produtos.Add("");
                produtos.Alignment = Element.ALIGN_LEFT;
                produtos.Add(tabela);

                //Dados finais do orçamento
                Paragraph dadosFinais = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosFinais.Alignment = Element.ALIGN_RIGHT;
                dadosFinais.Add($"SubTotal: {mtbSubTotal.Text}    Desconto: {mtbDD.Text}     Agréscimo: {mtbAD.Text}      Total: {mtbTotal.Text}");

                //Obs
                Paragraph obs = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                obs.Alignment = Element.ALIGN_LEFT;
                obs.Add($"Obeservação: \n{txtObs.Text}");

                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("caminho");

                doc.Open();
                doc.Add(logo);
                doc.Add(cabecario);
                doc.Add(dataHora);
                doc.Add(dadosOrcamento);
                doc.Add(produtos);
                doc.Add(dadosFinais);
                doc.Add(obs);
                doc.Close();

                Gravar();
                new Helpers().LimparTela(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} Como o caminho para {ex.StackTrace}");               
            }
        }
        #endregion

        #region PassarItemPDF
        public void ItemPDF()
        {
            OrcamentoDAO dao = new OrcamentoDAO();
            try
            {
                foreach (DataRow linha in dgOrcamento.Rows)
                {
                    ItemOrcamento item = new ItemOrcamento();

                    item.CodigoOrcamento = dao.UltimoOrcamento();
                    item.CodigoProduto = int.Parse(linha["Código"].ToString());
                    item.Quantidade = int.Parse(linha["Quantidade"].ToString());
                    item.Subtotal = Decimal.Parse(linha["Total"].ToString());

                    ItemOrcamentoDAO itemVendaDAO = new ItemOrcamentoDAO();
                    itemVendaDAO.CadastrarItemOrcamento(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region DescontarDinheiro
        private void mtbDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal dd = decimal. Parse(mtbDD.Text);
                decimal total = decimal.Parse(mtbTotal.Text);

                decimal resultado = total - dd;

                mtbAteracoes.Text = dd.ToString();
                totalDD = resultado;
                mtbTotal.Text = totalDD.ToString();
            }
        }
        #endregion

        #region AcrescimoDineiro
        private void mtbAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal ad = decimal.Parse(mtbAD.Text);
                decimal total = decimal.Parse(mtbTotal.Text);

                decimal resultado = total + ad;

                mtbAteracoes.Text = ad.ToString();
                totalAD = resultado;
                mtbTotal.Text = totalAD.ToString();
            }
        }
        #endregion

        #region DescontoPorgentagem
        private void mtbDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                decimal dp = decimal.Parse(mtbDP.Text);
                decimal total = decimal.Parse(mtbTotal.Text);

                decimal resultadoPorcentagem = (dp * total) / 100;

                total -= resultadoPorcentagem;
                totalDP = total;
                mtbAteracoes.Text = resultadoPorcentagem.ToString();
                mtbTotal.Text = totalDP.ToString();
            }
        }
        #endregion

        #region AgrescimoPorgentagem
        private void mtbAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal ap = decimal.Parse(mtbDP.Text);
                decimal total = decimal.Parse(mtbTotal.Text);

                decimal resultadoPorcentagem = (ap * total) / 100;

                total -= resultadoPorcentagem;
                totalAP = total;
                mtbAteracoes.Text = resultadoPorcentagem.ToString();
                mtbTotal.Text = totalAP.ToString();
            }
        }
        #endregion

        #region PesquisarOrcamentoID
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                OrcamentoDAO dao = new OrcamentoDAO();
                obj = dao.ConsultarOrcamentoCodigo(idOrcamento);

                FuncionarioDAO funD = new FuncionarioDAO();
                cbVendedor.DataSource = funD.ConsultarFuncionario();
                cbVendedor.DisplayMember = "nome";
                cbVendedor.ValueMember = "id";

                ClienteDAO cliD = new ClienteDAO();
                cbCliente.DataSource = cliD.ConsultarClientes();
                cbCliente.DisplayMember = "nome";
                cbCliente.ValueMember = "id";

                txtCodigo.Text = obj.Codigo.ToString();
                cbCliente.SelectedValue = obj.CodigoCliente.ToString();
                cbVendedor.SelectedValue = obj.CodigoVendedor.ToString();
                mtbDP.Text = obj.DescontoPorcentagem.ToString();
                mtbDD.Text = obj.DescontoReal.ToString();
                mtbAP.Text = obj.AcrescimoPorcentagem.ToString();
                mtbAD.Text = obj.AcrescimoReal.ToString();
                mtbSubTotal.Text = obj.SubTotal.ToString();
                mtbTotal.Text = obj.Total.ToString();
                mtbAteracoes.Text = obj.Alteracoes.ToString();
                //dtpDataInicio.Text = obj.Data.ToString();
                //dtpDataFim.Text = obj.Data.ToString();
                txtObs.Text = obj.Obs.ToString();


                ItemOrcamentoDAO orcamentoDAO = new ItemOrcamentoDAO();
                dgOrcamento.DataSource = orcamentoDAO.ListarItemOrcamento(idOrcamento);

            }
        }
        #endregion

        #region btnSair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region btnConfirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clientDao = new ClienteDAO();
                OrcamentoDAO obj = new OrcamentoDAO();

                string nome = cbCliente.Text;

                if (txtCodigo.Text == String.Empty)
                {
                    Gravar();
                }

                Cliente cliente = new Cliente();
                ItemOrcamentoDAO item = new ItemOrcamentoDAO();
                frmVenda venda = new frmVenda();

                idOrcamento = obj.UltimoOrcamento();
                cliente = clientDao.ListarNome(nome);
                venda.dgCarrinho.Columns.Clear();
                venda.dgCarrinho.DataSource = item.ListarItemOrcamento(idOrcamento);

                venda.txtID.Text = cliente.Codigo.ToString();
                venda.txtNome.Text = cliente.Nome;
                venda.mtbCPF.Text = cliente.CPF;
                venda.mtbFone.Text = cliente.Celular;
                venda.txtEndereco.Text = $"{cliente.Cidade}, {cliente.Bairro}, {cliente.Logradouro}, {cliente.Numero}, {cliente.Complemento}";
                venda.mtbAlteracaoP.Text = mtbAP.Text;
                venda.mtbAlteracaoR.Text = mtbAD.Text;
                venda.mtbDescontoPorcentagem.Text = mtbDP.Text;
                venda.mtbDescontoReal.Text = mtbDD.Text;
               
                venda.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

 
    }
}
