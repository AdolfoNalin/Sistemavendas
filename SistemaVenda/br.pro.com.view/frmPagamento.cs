using iTextSharp.text.pdf;
using iTextSharp.text;
using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.veiw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmPagamento : Form
    {
        #region Objetos
        DataTable Carrinho = new DataTable();
        DataGridView DGCarrinho = new DataGridView();
        Cliente Cliente = new Cliente();
        string fun = "";
        #endregion

        #region Construtor
        public frmPagamento(Cliente cliente, DataTable carrinho, DataGridView dgCarrinho,String funcionario)
        {
            this.Cliente = cliente;
            this.Carrinho = carrinho;
            this.DGCarrinho = dgCarrinho;
            fun = funcionario;

            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmPagamento_Load(object sender, EventArgs e)
        {
            double num = 0.00;
            mtbDinheiro.Text = String.Format("{0:0.00}", num);
            mtbCartao.Text = String.Format("{0:0.00}", num);
            mtbPix.Text = String.Format("{0:0.00}", num);
            mtbCrediario.Text = String.Format("{0:0.00}", num);

            mtbDinheiro.Focus();
        }
        #endregion

        #region ImprimirPDF
        public void ImprimirPDF()
        {
            try
            {
                frmVenda venda = new frmVenda();
                frmMenu menu = new frmMenu();

                string nomeArquivo = "";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    nomeArquivo = $"{filePath}_Venda.pdf";
                }

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\repos\SistemaVenda\Logo.jpeg");
                logo.ScaleToFit(150, 300);
                logo.SetAbsolutePosition(430f, 650f);

                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escrito = PdfWriter.GetInstance(doc, arquivoPDF);

                string dado = " ";

                Paragraph cabecario = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

                //Dados da empresa
                cabecario.Alignment = Element.ALIGN_LEFT;
                cabecario.Add("Venda\nMaster Blocos e Lajes\nLuciane Pela Feijão: 46.594.384/0001-19\nEndereço: Rod SP 261 - Km 46,5\r\nBairro Jacutinga - zona rural \r\nÁguas de Santa Barbara\nContato: 14 99147 7975\nEmail: Luciani.pela@gmail.com");

                //Data e Hora
                Paragraph dataHora = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
                dataHora.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                dataHora.Alignment = Element.ALIGN_RIGHT;
                dataHora.Add($"\nData: {DateTime.Now.ToShortDateString()} Hora: {DateTime.Now.ToShortTimeString()}\n");

                Paragraph dadosCliente = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)FontStyle.Bold));
                dadosCliente.Alignment = Element.ALIGN_LEFT;
                dadosCliente.Add($"Cliente: {Cliente.Nome},\nCidade: {Cliente.Cidade}, \nBairro: {Cliente.Bairro}, \nRua: {Cliente.Logradouro}, \nNº: {Cliente.Numero}");

                //Dados do Orçamento
                Paragraph dadosOrcamento = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosOrcamento.Alignment = Element.ALIGN_LEFT;
                dadosOrcamento.Add($"Vendedor: {fun}\n");

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

                for (int i = 0; i < Carrinho.Rows.Count; i++)
                {
                    Produto obj = new Produto();

                    obj.Codigo = int.Parse(DGCarrinho.CurrentRow.Cells[0].Value.ToString());
                    obj.DescricaoResumida = DGCarrinho.CurrentRow.Cells[1].Value.ToString();
                    obj.Quantidade = int.Parse(DGCarrinho.CurrentRow.Cells[2].Value.ToString());
                    obj.PrecoVista = Decimal.Parse(DGCarrinho.CurrentRow.Cells[3].Value.ToString());
                    obj.ValorTotal = Decimal.Parse(DGCarrinho.CurrentRow.Cells[4].Value.ToString());

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
                dadosFinais.Alignment = Element.ALIGN_LEFT;
                dadosFinais.Add($"Desconto: {venda.mtbDescontoReal.Text}    Total: {mtbTotal.Text}");

                //Obs
                Paragraph obs = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                obs.Alignment = Element.ALIGN_LEFT;
                obs.Add($"Obeservação: \n{txtObs.Text}");

                doc.Open();
                doc.Add(logo);
                doc.Add(cabecario);
                doc.Add(dataHora);
                doc.Add(dadosCliente);
                doc.Add(dadosOrcamento);
                doc.Add(produtos);
                doc.Add(dadosFinais);
                doc.Add(obs);
                doc.Close();

                DialogResult result = MessageBox.Show("Deseja realizar outrar venda? ", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    venda.Hide();       
                    Hide();
                    venda.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} Como o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region btnFinalizarVenda
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dinheiro = decimal.Parse(mtbDinheiro.Text);
                decimal cartao = decimal.Parse(mtbCartao.Text);
                decimal total = decimal.Parse(mtbTotal.Text);
                decimal pago = 0;
                decimal troco = 0;

                pago = dinheiro + cartao;

                if (pago < total)
                {
                    MessageBox.Show("O total pago é menor do que o total da compra");
                }
                else
                {
                    troco = pago - total;

                    Venda obj = new Venda();

                    obj.CodigoCliente = Cliente.Codigo;
                    obj.Data = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                    obj.Hora = DateTime.Parse(DateTime.Now.ToShortTimeString());
                    obj.TotalVenda = total;
                    obj.Observacao = txtObs.Text;

                    VendaDAO dao = new VendaDAO();
                    dao.CadastrarVenda(obj);

                    foreach (DataRow linha in Carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();

                        item.CodigoVenda = dao.UltimaVenda();
                        item.CodigoProduto = int.Parse(linha["Código"].ToString());
                        item.Quantidade = int.Parse(linha["Quantidade"].ToString());
                        item.Subtotal = Decimal.Parse(linha["Total"].ToString());
                        
                        ItemVendaDAO itemVendaDAO = new ItemVendaDAO();
                        itemVendaDAO.CadastrarItemVenda(item);
                    }

                    MessageBox.Show($"Venda realizada com sucesso!");

                    ImprimirPDF();

                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region Dinheiro
        private void mtbDinheiro_KeyPress(object sender, KeyPressEventArgs e)
      {
            if(e.KeyChar == 13)
            {
                decimal dinheiro = decimal.Parse(mtbDinheiro.Text);
                decimal total = decimal.Parse(mtbTotal.Text);
                decimal troco = 0;

                troco = dinheiro - total;
                txtTroco.Text = troco.ToString();
            }
        }
        #endregion

        #region Cartao
        private void mtbCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                decimal cartao = decimal.Parse(mtbCartao.Text);
                decimal total = decimal.Parse(mtbTotal.Text);
                
                if (cartao < total)
                {
                    MessageBox.Show("Não é possivel o valor do pix ser maior do que o total da compra");
                }
            }
        }
        #endregion

        #region Pix
        private void mtbPix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                decimal pix = decimal.Parse(mtbPix.Text);
                decimal total = decimal.Parse(mtbTotal.Text);
                
                if(pix < total)
                {
                    MessageBox.Show("Não é possivel o valor do pix ser maior do que o total da compra");
                }
            }

        }
        #endregion
    }
}
