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
        DataTable minhaTabela = new DataTable();
        

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
        decimal subtotalProdutoVista = 0;
        decimal subtotalProdutoPrazo = 0;
        decimal descontoPorcentagem = 0;
        decimal descontoReal = 0;
        decimal total = 0;
        #endregion

        #region Load
        private void frmCadastrarOrcamento_Load(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);

            decimal num = 0;

            FuncionarioDAO dao = new FuncionarioDAO();
            ClienteDAO daoC = new ClienteDAO();

            if (txtCodigo.Text == String.Empty)
            { 

                cbVendedor.DataSource = dao.ConsultarFuncionario();
                cbCliente.DataSource = daoC.ConsultarClientes();

                mtbTotal.Text = String.Format("{0:0.00}", num);
                mtbSubTotal.Text = String.Format("{0:0.00}", num);
                mtbDD.Text = String.Format("{0:0.00}", num);
                mtbDP.Text = String.Format("{0:0.00}", num);
                mtbAteracoes.Text = String.Format("{0:0.00}", num);
                mtbAP.Text = String.Format("{0:0.00}", num);
                mtbAD.Text = String.Format("{0:0.00}", num);

                mtbData.Text = DateTime.Now.ToShortDateString();
                mtbHora.Text = DateTime.Now.ToShortTimeString();

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
        //public void Gravar()
        //{
        //    try
        //    {
        //        DataRow novaLinha = minhaTabela.NewRow();
        //        ClienteDAO clienteDao = new ClienteDAO();
        //        FuncionarioDAO funcionarioDao = new FuncionarioDAO();

        //        Cliente = clienteDao.ListarNome(cbCliente.Text);
        //        Funcionario = funcionarioDao.ListarNome(cbVendedor.Text);

        //        quantidadeP = int.Parse(dgOrcamento.CurrentRow.Cells[2].Value.ToString());
        //        int quantidadeTotal = 0;

        //        quantidadeTotal += quantidadeP;

        //        Orcamento orcamento = new Orcamento();

        //        orcamento.CodigoCliente = Cliente.Codigo;
        //        orcamento.CodigoVendedor = Funcionario.Codigo;

        //        orcamento.DescontoPorcentagem = Decimal.Parse(mtbDP.Text);
        //        orcamento.DescontoReal = Decimal.Parse(mtbDD.Text);
        //        orcamento.AcrescimoPorcentagem = Decimal.Parse(mtbAP.Text);
        //        orcamento.AcrescimoReal = Decimal.Parse(mtbAP.Text);
        //        orcamento.SubTotal = Decimal.Parse(mtbSubTotal.Text);
        //        orcamento.Total = Decimal.Parse(mtbTotal.Text);
        //        orcamento.Alteracoes = Decimal.Parse(mtbAteracoes.Text);
        //        orcamento.Obs = txtObs.Text;
        //        orcamento.Data = DateTime.Parse(mtbData.Text);
        //        orcamento.Hora = DateTime.Parse(mtbHora.Text);
        //        orcamento.QuantidadeTotal = quantidadeTotal;

        //        OrcamentoDAO dao = new OrcamentoDAO();
        //        dao.CadastrarOrcamento(orcamento);

        //        foreach (DataGridViewRow linha in dgOrcamento.Rows)
        //        {
        //            ItemOrcamento item = new ItemOrcamento();
        //            item.CodigoOrcamento = dao.UltimoOrcamento();
        //            item.CodigoProduto = int.Parse(linha.Cells[0].Value.ToString());
        //            item.Quantidade = int.Parse(linha.Cells[2].Value.ToString());
        //            item.Subtotal = Decimal.Parse(linha.Cells[5].Value.ToString());

        //            ItemOrcamentoDAO itemDao = new ItemOrcamentoDAO();
        //            itemDao.CadastrarItemOrcamento(item);
        //        }

        //        txtCodigo.Text = dao.UltimoOrcamento().ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
        //    }
        //}
        #endregion

        #region btnGravar
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();

            new Helpers().Gravar(dgOrcamento,cbVendedor.Text,cbCliente.Text, orcamento);
        }
        #endregion

        #region btnAdicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(rbtnVista.Checked == false && rbtnPrazo.Checked == false)
            {
                MessageBox.Show("Por favor, antes de adicionar coloque a forma de pagamnto", "ATENÇÃO", MessageBoxButtons.OK);
            }
            else if(rbtnVista.Checked)
            {
                ProdutoDAO dao = new ProdutoDAO();
                int idProduto = int.Parse(cbDescricao.SelectedValue.ToString());
                Produto obj = dao.ConsultarProdutoNome(idProduto);
                quantidadeP = int.Parse(txtQuantidade.Text);
                descontoPorcentagem = decimal.Parse(mtbDP.Text);
                descontoReal = decimal.Parse(mtbDD.Text);
                precoVista = obj.PrecoVista;
                precoPrazo = obj.PrecoPrazo;

                subtotalProdutoVista = precoVista * quantidadeP;
                quantidadeTotal += quantidadeP;
                try
                {
                    if (txtCodigo.Text == String.Empty)
                    {

                        dgOrcamento.Rows.Add(obj.Codigo, cbDescricao.Text, quantidadeP, precoVista, precoPrazo, subtotalProdutoVista);
                        total += subtotalProdutoVista;

                    }
                    else if (txtCodigo.Text != String.Empty)
                    {
                        minhaTabela = (DataTable)dgOrcamento.DataSource;
                        DataRow novaLinha = minhaTabela.NewRow();
                        novaLinha["´Código"] = obj.Codigo;
                        novaLinha["Descrição"] = cbDescricao.Text;
                        novaLinha["Quantidade"] = quantidadeP;
                        novaLinha["Preço á Vista"] = precoVista;
                        novaLinha["Preço á Prazo"] = precoPrazo;
                        novaLinha["SubTotal"] = subtotalProdutoVista;
                        minhaTabela.Rows.Add(novaLinha);

                        subtotalProdutoVista = Decimal.Parse(mtbSubTotal.Text);

                        subtotalProdutoVista += Decimal.Parse(novaLinha["SubTotal"].ToString());
                        total = subtotalProdutoVista;
                    }
                    txtQuantidade.Clear();
                }
                catch (NullReferenceException NRF)
                {
                    DialogResult resp = MessageBox.Show("Por favor, digite a quantidade do produto!", "Atenção", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        txtQuantidade.Focus();
                    }
                }
            }
            else
            {
                ProdutoDAO dao = new ProdutoDAO();
                int idProduto = int.Parse(cbDescricao.SelectedValue.ToString());
                Produto obj = dao.ConsultarProdutoNome(idProduto);
                quantidadeP = int.Parse(txtQuantidade.Text);
                descontoPorcentagem = decimal.Parse(mtbDP.Text);
                descontoReal = decimal.Parse(mtbDD.Text);
                precoPrazo = obj.PrecoPrazo;
                precoVista = obj.PrecoVista;
                subtotalProdutoPrazo = precoPrazo * quantidadeP;
                quantidadeTotal += quantidadeP;
                try
                {
                    if (txtCodigo.Text == String.Empty)
                    {

                        dgOrcamento.Rows.Add(obj.Codigo, cbDescricao.Text, quantidadeP, precoVista, precoPrazo, subtotalProdutoPrazo);
                        total += subtotalProdutoPrazo;

                    }
                    else if (txtCodigo.Text != String.Empty)
                    {
                        minhaTabela = (DataTable)dgOrcamento.DataSource;
                        DataRow novaLinha = minhaTabela.NewRow();
                        novaLinha["´Código"] = obj.Codigo;
                        novaLinha["Descrição"] = cbDescricao.Text;
                        novaLinha["Quantidade"] = quantidadeP;
                        novaLinha["Preço á Vista"] = precoVista;
                        novaLinha["Preço á Prazo"] = precoPrazo;
                        novaLinha["SubTotal"] = subtotalProdutoPrazo;
                        minhaTabela.Rows.Add(novaLinha);

                        subtotalProdutoPrazo = Decimal.Parse(mtbSubTotal.Text);

                        subtotalProdutoPrazo += Decimal.Parse(novaLinha["SubTotal"].ToString());
                        total = subtotalProdutoPrazo;
                    }
                    txtQuantidade.Clear();
                }
                catch (Exception ex)
                {

                    DialogResult resp = MessageBox.Show("Por favor, digite a quantidade do produto!", "Atenção", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        txtQuantidade.Focus();
                    }
                }
            }

            mtbSubTotal.Text = total.ToString();
            mtbTotal.Text = total.ToString();
            
        }
        #endregion

        #region btnRemover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subProduto = decimal.Parse(dgOrcamento.CurrentRow.Cells[5].Value.ToString());
                int indici = dgOrcamento.CurrentRow.Index;
                total -= subProduto;

                dgOrcamento.Rows.RemoveAt(indici);

                if (dgOrcamento.DataSource != null)
                {
                    total = 0;
                    mtbSubTotal.Text = total.ToString();
                    mtbTotal.Text = total.ToString();
                }
                else 
                {
                    mtbSubTotal.Text = total.ToString();
                    mtbTotal.Text = total.ToString();
                }
            }catch(Exception ex)
            {

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
                else if(nomeArquivo == String.Empty)
                {
                    DialogResult resp = MessageBox.Show("Não deseja salvar o orçamento?", "ATENÇÃO",MessageBoxButtons.YesNo);
                    if(resp == DialogResult.Yes)
                    {
                        saveFileDialog.Filter = "Text files (*.pdf)|*.pdf|All files (*.*)|*.*";
                        saveFileDialog.DefaultExt = "pdf";
                        saveFileDialog.AddExtension = false;
                    }
                }

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Program Files (x86)\Sistema de Vendas\Logo.jpeg");
                logo.ScaleToFit(150, 300);
                logo.SetAbsolutePosition(430f, 650f);

                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escrito = PdfWriter.GetInstance(doc, arquivoPDF);

                string dado = " ";

                Paragraph orcamentoCabecario = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
                orcamentoCabecario.Alignment = Element.ALIGN_CENTER;
                orcamentoCabecario.Add("Orçamento");

                Paragraph cabecario = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                //Dados da empresa
                cabecario.Alignment = Element.ALIGN_LEFT;
                cabecario.Add("Master Blocos e Lajes\nLuciane Pela Feijão: 46.594.384/0001-19\nEndereço: Rod SP 261 - Km 46,5\r\nBairro Jacutinga - zona rural \r\nÁguas de Santa Barbara\nContato: 14 99147 7975\nEmail: Luciani.pela@gmail.com\n");

                //Data e Hora
                Paragraph dataHora = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
                dataHora.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                dataHora.Alignment = Element.ALIGN_RIGHT;
                dataHora.Add($"\nData: {DateTime.Now.ToShortDateString()} Hora: {DateTime.Now.ToShortTimeString()}");

                //Dados do Orçamento
                Paragraph dadosOrcamento = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosOrcamento.Alignment = Element.ALIGN_LEFT;
                dadosOrcamento.Add($"Vendedor: {cbVendedor.Text} \nCliente: {cbCliente.Text}");

                //Produtos
                Paragraph produtos = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                produtos.Alignment = Element.ALIGN_RIGHT;

                PdfPTable tabela = new PdfPTable(5);

                tabela.AddCell("Código");
                tabela.AddCell("Produto");
                tabela.AddCell("Quantidade");
                tabela.AddCell("Preço");
                tabela.AddCell("SubTotal");

                int quantidade = 0;

                foreach (DataGridViewRow linha in dgOrcamento.Rows)
                {
                    Produto obj = new Produto();
                    
                    obj.Codigo = int.Parse(linha.Cells[0].Value.ToString());
                    obj.DescricaoResumida = linha.Cells[1].Value.ToString();
                    obj.Quantidade = int.Parse(linha.Cells[2].Value.ToString());
                    obj.PrecoVista = Decimal.Parse(linha.Cells[3].Value.ToString());
                    obj.Subtotal = Decimal.Parse(linha.Cells[5].Value.ToString());

                    tabela.AddCell(obj.Codigo.ToString());
                    tabela.AddCell(obj.DescricaoResumida.ToString());
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
                dadosFinais.Alignment = Element.ALIGN_LEFT;
                dadosFinais.Add($"\nSubTotal: {mtbSubTotal.Text}  \nDesconto: {mtbDD.Text}     \nAgréscimo: {mtbAD.Text}      \nTotal: {mtbTotal.Text}");

                //Obs
                Paragraph obs = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                obs.Alignment = Element.ALIGN_LEFT;
                obs.Add($"\nObeservação: \n{txtObs.Text}");

                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("caminho");

                doc.Open();
                doc.Add(orcamentoCabecario);
                doc.Add(logo);
                doc.Add(cabecario);
                doc.Add(dataHora);
                doc.Add(dadosOrcamento);
                doc.Add(produtos);
                doc.Add(dadosFinais);
                doc.Add(obs);
                doc.Close();

                Orcamento orcamento = new Orcamento();
                OrcamentoDAO dao = new OrcamentoDAO();
                txtCodigo.Text = dao.UltimoOrcamento().ToString();
                new Helpers().LimparTela(this);
                new Helpers().Gravar(dgOrcamento, cbVendedor.Text, cbCliente.Text, orcamento);
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
                    Orcamento orcamento = new Orcamento();
                    new Helpers().Gravar(dgOrcamento, cbVendedor.Text, cbCliente.Text, orcamento);
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
                venda.mtbAgrescimoP.Text = mtbAP.Text;
                venda.mtbAgrescimoD.Text = mtbAD.Text;
                venda.mtbDescontoPorcentagem.Text = mtbDP.Text;
                venda.mtbDescontoReal.Text = mtbDD.Text;
                venda.mtbTotal.Text = mtbTotal.Text;
               
                venda.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro {ex.Message} com o caminho {ex.StackTrace}");
            }
        }

        #endregion

        #region ClickrbtnVistaCheck
        private void rbtnVista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVista.Checked && dgOrcamento.Rows.Count > 0)
            {
                try
                {
                    subtotalProdutoVista = 0;
                    foreach (DataGridViewRow linha in dgOrcamento.Rows)
                    {
                        decimal valorVista = Decimal.Parse(linha.Cells[3].Value.ToString());
                        int quantidade = int.Parse(linha.Cells[2].Value.ToString());

                        linha.Cells[5].Value = quantidade * valorVista;
                        subtotalProdutoVista += Decimal.Parse(linha.Cells[5].Value.ToString());
                    }

                    total = subtotalProdutoVista;

                    mtbTotal.Text = total.ToString();
                    mtbSubTotal.Text = total.ToString();
                    subtotalProdutoVista = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                }
            }
        }
           
        #endregion

        #region ClickrbtnPrazocheck
        private void rbtnPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrazo.Checked && dgOrcamento.Rows.Count > 0)
            {
                try
                {
                    subtotalProdutoPrazo = 0;
                    foreach (DataGridViewRow linha in dgOrcamento.Rows)
                    {
                        decimal valorPrazo = Decimal.Parse(linha.Cells[4].Value.ToString());
                        int quantidade = int.Parse(linha.Cells[2].Value.ToString());

                        linha.Cells[5].Value = quantidade * valorPrazo;
                        subtotalProdutoPrazo += Decimal.Parse(linha.Cells[5].Value.ToString());
                    }

                    total = subtotalProdutoPrazo;

                    mtbTotal.Text = total.ToString();
                    mtbSubTotal.Text = total.ToString();
                    subtotalProdutoPrazo = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                }
            }
        }
        #endregion
    }
}
