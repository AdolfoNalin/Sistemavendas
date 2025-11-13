using iTextSharp.text.pdf;
using iTextSharp.text;
using SistemaVenda.Service;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.View;
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
using Google.Protobuf.WellKnownTypes;
using SistemaVenda.Model;
using ZstdSharp.Unsafe;
using System.Management;
using MySqlX.XDevAPI.Common;
using Microsoft.Extensions.Logging;
using iTextSharp.text.pdf.parser;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmPayment : Form
    {
        #region Objects
        private BindingList<ProductShoppingCar> _proShoCar = new BindingList<ProductShoppingCar>();
        private Client _client = new Client();
        private Employee _emp;
        private Sale _sale;
        private string _paymentoMethod = "";
        private bool _update;
        #endregion

        #region Construtor
        public frmPayment(Client client, BindingList<ProductShoppingCar> proShoCar,Employee employee, Sale sale, bool update)
        {
            _client = client;
            _proShoCar = proShoCar;
            _emp = employee;
            _sale = sale;
            _update = update;
           
            InitializeComponent();
        }
        #endregion

        #region ImprimirPDF
        public void ImprimirPDF()
        {
            try
            {
                frmSale saleScreen = new frmSale();
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

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Program Files (x86)\Sistema de Vendas\Logo.jpeg");
                logo.ScaleToFit(150, 300);
                logo.SetAbsolutePosition(430f, 650f);

                FileStream filePDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escrito = PdfWriter.GetInstance(doc, filePDF);

                string data = " ";

                Paragraph vendaCabecario = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
                vendaCabecario.Alignment = Element.ALIGN_CENTER;
                vendaCabecario.Add("Venda");

                Paragraph cabecario = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

                //Dados da empresa
                cabecario.Alignment = Element.ALIGN_LEFT;
                cabecario.Add($"Master Blocos e Lajes\nLuciane Pela Feijão: 46.594.384/0001-19\nEndereço: Rod SP 261 - Km 46,5\r\nBairro Jacutinga - zona rural \r\nÁguas de Santa Barbara\nContato: 14 99147 7975\nEmail: Luciani.pela@gmail.com");

                //Data e Hora
                Paragraph dateTime = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
                dateTime.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                dateTime.Alignment = Element.ALIGN_RIGHT;
                dateTime.Add($"\nData: {DateTime.Now.ToShortDateString()} Hora: {DateTime.Now.ToShortTimeString()}\n\n");

                Paragraph dataClient= new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)FontStyle.Bold));
                dataClient.Alignment = Element.ALIGN_LEFT;
                dataClient.Add($"Cliente: {_client.Name},\nCidade: {_client.City}, \nBairro: {_client.Neighborhoods}, \nRua: {_client.ShortName}, \nNº: {_client.Number}");

                //Dados do Orçamento
                Paragraph dadosOrcamento = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosOrcamento.Alignment = Element.ALIGN_LEFT;
                dadosOrcamento.Add($"Vendedor: {_emp.Name}\n");

                //Produtos
                Paragraph produtos = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                produtos.Alignment = Element.ALIGN_RIGHT;

                PdfPTable tabela = new PdfPTable(5);

                tabela.AddCell("Código");
                tabela.AddCell("Produto");
                tabela.AddCell("Quantidade");
                tabela.AddCell("Preço");
                tabela.AddCell("SubTotal");

                double quantidade = 0;

                //foreach (var linha in _proShoCar)
                //{
                //    Product obj = new Product();

                //    obj.Id = Guid.Parse(linha.Cells[0].Value.ToString());
                //    obj.ShortDescription = linha.Cells[1].Value.ToString();
                //    obj.Amount = int.Parse(linha.Cells[2].Value.ToString());
                //    obj.CashPrice = Decimal.Parse(linha.Cells[3].Value.ToString());
                //    obj.TermPrice = Decimal.Parse(linha.Cells[4].Value.ToString());

                //    tabela.AddCell(obj.Id.ToString());
                //    tabela.AddCell(obj.ShortDescription);
                //    tabela.AddCell(obj.Amount.ToString());
                //    tabela.AddCell(obj.CashPrice.ToString());

                //    quantidade += obj.Amount;
                //}

                tabela.HorizontalAlignment = Element.ALIGN_LEFT;

                produtos.Add("");
                produtos.Alignment = Element.ALIGN_LEFT;
                produtos.Add(tabela);

                //Dados finais do orçamento
                Paragraph dadosFinais = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosFinais.Alignment = Element.ALIGN_LEFT;
                dadosFinais.Add($"SubTotal: {saleScreen.txtTotal.Text}    Desconto: {saleScreen.mtbCashDiscount.Text}     Agréscimo: {saleScreen.mtbAdditionCash.Text}      Total: {txtTotal.Text}");

                //Obs
                Paragraph obs = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                obs.Alignment = Element.ALIGN_LEFT;
                obs.Add($"Obeservação: \n{txtObs.Text}");

                doc.Open();
                doc.Add(vendaCabecario);
                doc.Add(logo);
                doc.Add(cabecario);
                doc.Add(dateTime);
                doc.Add(dataClient);
                doc.Add(dadosOrcamento);
                doc.Add(produtos);
                doc.Add(dadosFinais);
                doc.Add(obs);
                doc.Close();

                DialogResult result = MessageBox.Show("Deseja realizar outrar venda? ", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    saleScreen.Hide();       
                    Hide();
                    saleScreen.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} Como o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region btnFinalizarVenda
        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if (screen.user != null)
                {
                    decimal cash = decimal.Parse(mtbCash.Text);
                    decimal card = decimal.Parse(mtbCard.Text);
                    decimal total = decimal.Parse(txtTotal.Text);
                    decimal pay = 0;
                    decimal troco = 0;

                    pay = cash + card;

                    if (pay < total)
                    {
                        MessageBox.Show("O total pago é menor do que o total da compra");
                    }
                    else if (!_update)
                    {
                        troco = pay - total;

                        CashMovement moviment = new CashMovement()
                        {
                            CashSessionId = CashDesck.Id,
                            UserId = screen.user.User.Id,
                            Amount = _sale.Total,
                            Type = Model.Type.Entry,
                            Date = _sale.Date,
                            Description = "Venda"
                        };

                        CashMovementService.Post(moviment);

                        CashDesck.Total += moviment.Amount;

                        CashSession session = await CashSessionService.Get(CashDesck.Id);
                        session.Total = CashDesck.Total;
                        CashSessionService.Put(session);

                        _sale.PaymentMethod = _paymentoMethod
                            ?? throw new ArgumentNullException("Para finalizar é necessário ralizar o pagamento!");
                        _sale.Observation = txtObs.Text;

                        bool value = await SaleService.Post(_sale);
                        if (value)
                        {
                            Sale sale = await SaleService.LastSale() ??
                                throw new ArgumentNullException("Venda não foi identificada");

                            List<ItemSale> itens = new List<ItemSale>();
                            foreach (var i in _proShoCar)
                            {
                                ItemSale item = new ItemSale();
                                List<Product> products = await ProductService.Get(i.ShortDescription);
                                Product product = products.FirstOrDefault() ??
                                    throw new ArgumentNullException("Produto não encontrado");

                                item.SaleId = sale.Id;
                                item.ProductId = product.Id;
                                item.Amount = i.Amount;
                                item.Subtotal = i.TotalPrice;

                                itens.Add(item);
                            }

                            bool result = false;
                            if (await ItemSaleService.Post(itens))
                            {
                                foreach (var i in itens)
                                {
                                    Product product = await ProductService.Get(i.ProductId);
                                    decimal withdrawal = Convert.ToDecimal(product.Amount - i.Amount);

                                    result = await ProductService.StockManager(productId: product.Id, withdrawal: withdrawal);

                                    if (result == false)
                                    {
                                        throw new Exception("Algo deu errado!");
                                    }
                                }

                                if (result)
                                {
                                    MessageBox.Show($"Venda realizada com sucesso!");
                                }
                            }

                            //ImprimirPDF();

                            this.Dispose();
                        }
                    }
                    else if (_update)
                    {
                        List<ItemSale> itens = new List<ItemSale>();
                        troco = pay - total;

                        _sale.PaymentMethod = _paymentoMethod
                            ?? throw new ArgumentNullException("Para finalizar é necessário ralizar o pagamento!");
                        _sale.Observation = txtObs.Text;

                        bool value = await SaleService.Put(_sale);
                        if (value)
                        {
                            foreach (var i in _proShoCar)
                            {
                                ItemSale item = new ItemSale();
                                List<Product> products = await ProductService.Get(i.ShortDescription);
                                Product product = products.FirstOrDefault() ??
                                    throw new ArgumentNullException("");

                                item.SaleId = _sale.Id;
                                item.ProductId = product.Id;
                                item.Amount = i.Amount;
                                item.Subtotal = i.TotalPrice;

                                itens.Add(item);
                            }

                            if (await ItemSaleService.Put(itens))
                            {
                                bool result = false;
                                foreach (var i in itens)
                                {
                                    Product product = await ProductService.Get(i.ProductId);
                                    decimal withdrawall = Convert.ToDecimal(product.Amount - i.Amount);
                                    result = await ProductService.StockManager(productId: i.ProductId, withdrawal: withdrawall);

                                    if (!result)
                                    {
                                        throw new Exception("Algo deu errado");
                                    }
                                }

                                MessageBox.Show("Venda foi atualizada com sucesso!");
                            }

                            this.Dispose();
                        }
                    }
                }
                

                new frmSale().ShowDialog();
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
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
                _paymentoMethod = "Dinheiro";
                decimal cash = decimal.Parse(mtbCash.Text);
                decimal total = decimal.Parse(txtTotal.Text);
                decimal change = 0;

                change = cash - total;
                txtChange.Text = change.ToString();
            }
        }
        #endregion

        #region Cartao
        private void mtbCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                _paymentoMethod = "Cartão";
                decimal card = decimal.Parse(mtbCard.Text);
                decimal total = decimal.Parse(txtTotal.Text);
                
                if (card < total)
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
                _paymentoMethod = "Pix";
                decimal pix = decimal.Parse(mtbPix.Text);
                decimal total = decimal.Parse(txtTotal.Text);
                
                if(pix < total)
                {
                    MessageBox.Show("Não é possivel o valor do pix ser maior do que o total da compra");
                }
            }

        }
        #endregion

        #region Load
        private void frmPagamento_Load(object sender, EventArgs e)
        {
            decimal num = 0;
   
            mtbCash.Text = String.Format("{0:0.00}", num);
            mtbCard.Text = String.Format("{0:0.00}", num);
            mtbPix.Text = String.Format("{0:0.00}", num);
            mtbCredit.Text = String.Format("{0:0.00}", num);

            txtTotal.Text = _sale.Total.ToString();
        }
        #endregion

        #region btnCancel_Click 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
