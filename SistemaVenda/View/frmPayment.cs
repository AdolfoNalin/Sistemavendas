
using SistemaVenda.Service;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SistemaVenda.Model;
using SistemaVenda.br.pro.com.model.Helpers;

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

                        if(await CashMovementService.Post(moviment))
                        {
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
                            }

                            //ImprimirPDF();

                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Verifique os dados da movimentação de caixa");
                        }
                    }
                    else if (_update)
                    {
                        List<ItemSale> itens = new List<ItemSale>();
                        troco = pay - total;

                        _sale.PaymentMethod = _paymentoMethod
                            ?? throw new ArgumentNullException("Para finalizar é necessário ralizar o pagamento!");
                        _sale.Observation = txtObs.Text;

                        CashMovement moviment = new CashMovement()
                        {
                            CashSessionId = CashDesck.Id,
                            UserId = screen.user.User.Id,
                            Amount = _sale.Total,
                            Type = Model.Type.Entry,
                            Date = _sale.Date,
                            Description = "Venda"
                        };

                        if (await CashMovementService.Put(moviment))
                        {
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
                            }


                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Verifique se todos os dados de movimentação de caixa estão todos preenchidos");
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

        #region mtbCard_KeyDown
        private void mtbCard_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal.TryParse(txtTotal.Text, out decimal total);
                    decimal result = Helpers.CalculateChange(Decimal.Parse(mtbCard.Text), total);

                    if(result != -404)
                    {
                        txtChange.Text = $"R${result.ToString().Replace(".", ",")}";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbPix_KeyDown
        private void mtbPix_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal.TryParse(txtTotal.Text, out decimal total);
                    decimal result = Helpers.CalculateChange(Decimal.Parse(mtbCard.Text), total);

                    if (result != -404)
                    {
                        txtChange.Text = $"R${result.ToString().Replace(".", ",")}";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbCash_KeyDown
        private void mtbCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal.TryParse(txtTotal.Text, out decimal total);
                    decimal result = Helpers.CalculateChange(Decimal.Parse(mtbCard.Text), total);

                    if (result != -404)
                    {
                        txtChange.Text = $"R${result.ToString().Replace(".", ",")}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbCredit_KeyDown
        private void mtbCredit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Decimal.TryParse(txtTotal.Text, out decimal total);
                    decimal result = Helpers.CalculateChange(Decimal.Parse(mtbCard.Text), total);

                    if (result != -404)
                    {
                        txtChange.Text = $"R${result.ToString().Replace(".", ",")}";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}
