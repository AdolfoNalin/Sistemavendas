using MySqlX.XDevAPI.Common;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
        }

        private bool _update = false;
        private decimal _total = 0;
        private BindingList<ProductShoppingCar> _proCarSh = new BindingList<ProductShoppingCar>();

        #region UpdateDataReturn
        private async void UpdateDataReturn()
        {
            dgItemReturn.DataSource = await ReturnService.Get();
        }
        #endregion

        #region UpdateDataSale
        public async void UpdateDataSale()
        {
            dgSale.DataSource = await SaleService.Get();
        }
        #endregion

        #region UpdateDetailsReturn
        private void UpdateDetailsReturn()
        {
            if (dgItemReturn.SelectedRows.Count > 0)
            {
                ItemReturn item = dgItemReturn.SelectedRows[0].DataBoundItem as ItemReturn;
            }
        }
        #endregion

        #region UpdateDetailsSale
        private async void UpdateDetailsSale()
        {
            if (dgSale.SelectedRows.Count > 0)
            {
                Sale sale = dgSale.SelectedRows[0].DataBoundItem as Sale;

                Client client = await ClientService.Get(sale.ClientId);

                User user = await UserService.GetEmployee(sale.EmployeeId);

                BindingList<ItemSale> itens = await ItemSaleService.Get(sale.Id);

                string address = Helpers.Address(client);

                txtId.Text = sale.Id.ToString();
                txtClientId.Text = client.Id.ToString();
                txtName.Text = client.Name;
                mtbCPF.Text = client.CPF;
                txtAddress.Text = Helpers.Address(client);
                mtbPhone.Text = client.PhoneNumber;
                txtTotal.Text = sale.Total.ToString();

                cbUsers.Text = user.Login;

                foreach (var item in itens)
                {
                    ProductShoppingCar car = new ProductShoppingCar();
                    Product product = await ProductService.Get(item.ProductId);

                    car.ShortDescription = product.ShortDescription;
                    car.Amount = item.Amount;
                    car.CashPrice = product.CashPrice;
                    car.TermPrice = product.TermPrice;
                    car.TotalPrice = item.Subtotal;

                    _proCarSh.Add(car);
                }

                dgShoppingCar.DataSource = _proCarSh;
            }
        }
        #endregion

        #region dgSale_SelectionChanged
        private void dgSale_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetailsSale();
        }
        #endregion

        #region dgItemReturn_SelectionChanged
        private void dgItemReturn_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetailsReturn();
        }
        #endregion

        #region Load
        private async void frmItemReturn_Load(object sender, EventArgs e)
        {
            UpdateDataReturn();
            UpdateDataSale();

            mtbDate.Text = DateTime.Now.ToString();

            cbUsers.DataSource = await UserService.Get();
            cbUsers.ValueMember = "EmployeeId";
            cbUsers.DisplayMember = "name";
        }
        #endregion

        #region btnSearch_Click
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if(tapReturn.Name.Equals(tpConsult.Name))
            {
                dgItemReturn.DataSource = await ItemReturnService.Get(txtSearch.Text);
            }
            else
            {
                dgSale.DataSource = await SaleService.Get(txtSearch.Text);
            }
        }
        #endregion

        #region txtSearch_KeyDown
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnNew_click
        private void btnNew_Click(object sender, EventArgs e)
        {
            _update = false;
            tapReturn.SelectedTab = tpDetails;
        }
        #endregion

        #region btnSave_Click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Return @return = new Return()
                {
                    SaleId = Guid.Parse(txtId.Text),
                    ClientId = Guid.Parse(txtClientId.Text),
                    EmployeeId = Guid.Parse(cbUsers.SelectedValue.ToString()),
                    Date = DateTime.Parse(mtbDate.Text).ToUniversalTime(),
                    Total = Decimal.Parse(txtTotal.Text)
                };

                if (_update)
                {
                    @return.Id = Guid.Parse(txtId.Text);

                    if(await ReturnService.Put(@return))
                    {
                        BindingList<ItemReturn> returns = new BindingList<ItemReturn>();

                        foreach (var item in _proCarSh) 
                        { 
                            List<Product> products = await ProductService.Get(item.ShortDescription);
                            Product product = products.FirstOrDefault();

                            ItemReturn itemReturn = new ItemReturn()
                            {
                                Id = await ItemReturnService.GetIdReturn(@return.Id),
                                ReturnId = @return.Id,
                                ProductId = product.Id,
                                Amount = item.Amount,
                                Subtotal = item.TotalPrice,
                            };

                            returns.Add(itemReturn);
                        }

                        if (await ItemReturnService.Put(returns))
                        {
                            bool result = false;
                            foreach (var i in returns)
                            {
                                Product product = await ProductService.Get(i.ProductId);
                                decimal withdrawall = Convert.ToDecimal(product.Amount + i.Amount);
                                result = await ProductService.StockManager(productId: i.ProductId, withdrawal: withdrawall);

                                if (!result)
                                {
                                    throw new Exception("Algo deu errado");
                                }
                            }

                            MessageBox.Show("Devolução foi atualizada com sucesso!");
                        }
                    }
                }
                else
                {
                    if (await ReturnService.Post(@return))
                    {
                        BindingList<ItemReturn> returns = new BindingList<ItemReturn>();

                        foreach (var item in _proCarSh)
                        {
                            List<Product> products = await ProductService.Get(item.ShortDescription);
                            Product product = products.FirstOrDefault();

                            BindingList<Return> returns1 = await ReturnService.Get();
                            Return @return1 = returns1.LastOrDefault();

                            ItemReturn itemReturn = new ItemReturn()
                            {
                                ReturnId = @return1.Id,
                                ProductId = product.Id,
                                Amount = item.Amount,
                                Subtotal = item.TotalPrice,
                            };

                            returns.Add(itemReturn);
                        }

                        if (await ItemReturnService.Post(returns))
                        {
                            bool result = false;
                            foreach (var i in returns)
                            {
                                Product product = await ProductService.Get(i.ProductId);
                                decimal withdrawall = Convert.ToDecimal(product.Amount + i.Amount);
                                result = await ProductService.StockManager(productId: i.ProductId, withdrawal: withdrawall);

                                if (!result)
                                {
                                    throw new Exception("Algo deu errado");
                                }
                            }

                            MessageBox.Show("Devolução foi atualizada com sucesso!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgItemReturn.SelectedRows.Count > 0)
            {
                Return @return = dgItemReturn.SelectedRows[0].DataBoundItem as Return;

                ReturnService.Delete(@return.Id);
                await Task.Delay(200);
                UpdateDataReturn();
            }
            else
            {
                MessageBox.Show("Selecione um item não tabela");
            }
        }
        #endregion

        #region btnRemove_Click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgShoppingCar.SelectedRows.Count > 0)
                {
                    ProductShoppingCar product = (ProductShoppingCar)dgShoppingCar.SelectedRows[0].DataBoundItem;

                    _total -= product.TotalPrice;
                    txtTotal.Text = _total.ToString().Replace(".", ",");

                    _proCarSh.Remove(product);

                    dgShoppingCar.DataSource = _proCarSh;
                }
                else
                {
                    throw new ArgumentNullException("Nenhum item foi selecionado.");
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnAdd_Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnSport.Checked || rbtnTerm.Checked)
                {
                    ProductShoppingCar product = new ProductShoppingCar()
                    {
                        ShortDescription = txtShortDescription.Text,
                        Amount = Double.Parse(txtAmount.Text ?? throw new ArgumentException("Quantidade não pode ser vázia")),
                        CashPrice = Decimal.Parse(txtSpotPrice.Text),
                        TermPrice = Decimal.Parse(txtTermPrice.Text),
                    };

                    if (product is null)
                    {
                        throw new ArgumentNullException("Selecione o produto para ser adicionado ao carrinho!");
                    }

                    product.TotalPrice = rbtnSport.Checked ? product.CashPrice * Decimal.Parse(product.Amount.ToString()) : product.TermPrice * Decimal.Parse(product.Amount.ToString());

                    _proCarSh.Add(product);
                    _total = _proCarSh.Sum(p => p.TotalPrice);
                    txtTotal.Text = _total.ToString();
                    dgShoppingCar.DataSource = _proCarSh;

                    txtProductId.Clear();
                    txtAmount.Clear();
                    txtSpotPrice.Clear();
                    txtTermPrice.Clear();
                    txtStock.Clear();
                    txtShortDescription.Clear();

                    txtShortDescription.Focus();
                }
                else
                {
                    MessageBox.Show("Selecione a forma de pagamento");
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _update = true;
            tapReturn.SelectedTab = tpDetails; 
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tapReturn.SelectedTab = tpConsult;
            Helpers.ClearScreen(this);
        }
        #endregion
    }
}
