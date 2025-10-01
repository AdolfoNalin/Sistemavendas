using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.br.pro.com.view;
using SistemaVenda.Model;
using SistemaVenda.Model.Helpers;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
            DataUpdate();
        }

        private BindingList<ProductShoppingCar> _proCarSh = new BindingList<ProductShoppingCar>();
        private decimal _total;
        private bool _update = false;
        private Client _client;
        private int _countUpdate = 0;

        #region DataDetails
        private async void DataDetails()
        {
            try
            {
                if (dgSale.SelectedRows.Count > 0)
                {
                    Sale sale = (Sale)dgSale.SelectedRows[0].DataBoundItem;

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
                    mtbAdditionCash.Text = sale.AdditionCash.ToString();
                    mtbAdditionPorcentage.Text = sale.AdditionPorcentage.ToString();
                    mtbCashDiscount.Text = sale.CashDiscount.ToString();
                    mtbPorcentageDiscount.Text = sale.PercentageDiscount.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region DataUpdate
        private async void DataUpdate()
        {

            dgSale.DataSource = await SaleService.Get();
        }
        #endregion

        #region SearchCPF
        private async void SearchCPF()
        {
            try
            {
                List<Client> list = await ClientService.Get(mtbCPF.Text);

                _client = list.FirstOrDefault();

                txtClientId.Text = _client.Id.ToString();
                txtName.Text = _client.Name;
                mtbCPF.Text = _client.CPF;
                mtbPhone.Text = _client.PhoneNumber;
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Laod
        private async void frmSale_Load(object sender, EventArgs e)
        {
            //await Task.Delay(1000);
            DataUpdate();
            mtbDate.Text = DateTime.Now.ToString();
            txtClientId.Enabled = false;
            txtProductId.Enabled = false;
            cbUsers.DataSource = await UserService.Get();
            cbUsers.ValueMember = "employeeid";
            cbUsers.DisplayMember = "Name";


            dgShoppingCar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ShortDescription",
                HeaderText = "Descrição Resumida"
            });

            dgShoppingCar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Quantidade"
            });

            dgShoppingCar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CashPrice",
                HeaderText = "Preço á Vista"
            });

            dgShoppingCar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TermPrice",
                HeaderText = "Preço á Prazo"
            });

            dgShoppingCar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Subtotal"
            });

            rbtnSport.Checked = true;

            //btnNew_Click(sender, e);
        }
        #endregion

        #region dgSale_SelectionChanged
        private void dgSale_SelectionChanged(object sender, EventArgs e)
        {
            DataDetails();
        }
        #endregion

        #region btnNew
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgShoppingCar.Rows.Clear();
            Helpers.ClearScreen(this);
            mtbCPF.Text = "000.000.000-00";
            txtName.Text = "Consumidor";
            mtbAdditionCash.Text = "0.00";
            mtbAdditionPorcentage.Text = "0.00";
            mtbCashDiscount.Text = "0.00";
            mtbPorcentageDiscount.Text = "0.00";
            tabSale.SelectedTab = tpDetails;
            txtAddress.Clear();
        }
        #endregion

        #region btnSearchName_click
        private async void btnSearchName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            try
            {
                List<Client> list = await ClientService.Get(name);

                Client client = list.FirstOrDefault() ??
                    throw new ArgumentNullException("Cliente não encontrado!");

                txtClientId.Text = client.Id.ToString();
                mtbCPF.Text = client.CPF;
                txtName.Text = client.Name;
                mtbPhone.Text = client.PhoneNumber;
                txtAddress.Text = Helpers.Address(client);
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region txtShortDescription_KeyDown
        private async void txtShortDescription_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    List<Product> products = await ProductService.Get(txtShortDescription.Text);
                    Product product = products.FirstOrDefault() ?? throw new ArgumentNullException("Nenhum produto encontrado");

                    txtShortDescription.Text = product.ShortDescription;
                    txtTermPrice.Text = product.TermPrice.ToString();
                    txtSpotPrice.Text = product.CashPrice.ToString();
                    txtStock.Text = product.Amount.ToString();
                    txtProductId.Text = product.Id.ToString();

                    txtAmount.Focus();
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }

        }
        #endregion

        #region btnCancelar_Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmSale_Load(sender, KeyEventArgs.Empty);
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
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnRemove_Click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgShoppingCar.RowCount > 0)
                {
                    ProductShoppingCar product = (ProductShoppingCar)dgShoppingCar.SelectedRows[0].DataBoundItem;

                    _total -= product.TotalPrice;
                    txtTotal.Text = _total.ToString().Replace(".", ",");

                    _proCarSh.Remove(product);

                    dgShoppingCar.DataSource = _proCarSh;
                }
                else
                {
                    MessageBox.Show("Carrinho está vazio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnDelete_Click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Sale sale = (Sale)dgSale.SelectedRows[0].DataBoundItem;
            SaleService.Delete(sale.Id);
            DataUpdate();
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _proCarSh.Clear();
                //_proCarSh = (BindingList<ProductShoppingCar>)dgShoppingCar.DataSource;
                _update = true;
                DataDetails();
                tabSale.SelectedTab = tpDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabSale.SelectedTab = tpConsult;
        }
        #endregion

        #region txtSearch_KeyPress
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgSale.DataSource = SaleService.Get(txtSearch.Text);
        }
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgSale.DataSource = SaleService.Get(txtSearch.Text);
        }
        #endregion

        #region txtSearch_KeyDown
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region mtbCPF_KeyPress
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchCPF();
            }
        }
        #endregion

        #region txtName_KeyPress
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSearchName_Click(sender, e);
            }
        }
        #endregion

        #region txtAmount_KeyDown
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
        #endregion

        #region mtbPorcentageDiscount_KeyDown
        private void mtbPorcentageDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbPorcentageDiscount.Text.Equals("0") || mtbPorcentageDiscount.Text == String.Empty)
                    {
                        _total = _proCarSh.Sum(p => p.TotalPrice);
                        txtTotal.Clear();
                        txtTotal.Text = _total.ToString();
                        mtbCashDiscount.Text = "0.00";
                    }
                    else
                    {
                        _total = Convert.ToDecimal(txtTotal.Text);
                        Decimal.TryParse(mtbPorcentageDiscount.Text, out decimal value);
                        decimal result = Calculator.Porcentage(total: _total, value: value);
                        mtbCashDiscount.Text = result.ToString();
                        _total -= result;
                        txtTotal.Text = _total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbAdditionPorcentage_KeyDown
        private void mtbAdditionPorcentage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbAdditionPorcentage.Text.Equals("0") || mtbAdditionPorcentage.Text == String.Empty)
                    {
                        _total = _proCarSh.Sum(p => p.TotalPrice);
                        txtTotal.Clear();
                        txtTotal.Text = _total.ToString();
                        mtbAdditionCash.Text = "0.00";
                    }
                    else
                    {
                        _total = Convert.ToDecimal(txtTotal.Text);
                        Decimal.TryParse(mtbAdditionPorcentage.Text, out decimal value);
                        decimal result = Calculator.Porcentage(total: _total, value: value);
                        mtbAdditionCash.Text = result.ToString();
                        _total += result;
                        txtTotal.Text = _total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");

            }
        }
        #endregion

        #region mtbCashDiscount_KeyDown
        private void mtbCashDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbCashDiscount.Text.Equals("0") || mtbCashDiscount.Text == String.Empty)
                    {
                        _total = _proCarSh.Sum(p => p.TotalPrice);
                        txtTotal.Clear();
                        txtTotal.Text = _total.ToString();
                        mtbPorcentageDiscount.Text = "0.00";
                    }
                    else
                    {
                        Decimal.TryParse(mtbCashDiscount.Text, out decimal value);
                        decimal result = Calculator.Cash(total: _total, value: value);
                        mtbPorcentageDiscount.Text = result.ToString();
                        _total -= value;
                        txtTotal.Text = _total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbAdditionCash_KeyDown
        private void mtbAdditionCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbAdditionCash.Text.Equals("0") || mtbAdditionCash.Text == String.Empty)
                    {
                        _total = _proCarSh.Sum(p => p.TotalPrice);
                        txtTotal.Clear();
                        txtTotal.Text = _total.ToString();
                        mtbAdditionPorcentage.Text = "0.00";
                    }
                    else
                    {
                        Decimal.TryParse(mtbAdditionCash.Text, out decimal value);
                        decimal result = Calculator.Cash(total: _total, value: value);
                        mtbAdditionPorcentage.Text = result.ToString();
                        _total += value;
                        txtTotal.Text = _total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region rbtnSport_CheckedChanged
        private void rbtnSport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSport.Checked)
            {
                _proCarSh.ToList().ForEach(p => p.TotalPrice = 0);
                _proCarSh.ToList().ForEach(p =>
                {
                    p.TotalPrice = p.CashPrice * Decimal.Parse(p.Amount.ToString());
                });

                dgShoppingCar.DataSource = _proCarSh;
                dgShoppingCar.Refresh();
                _total = _proCarSh.Sum(p => p.TotalPrice);
                txtTotal.Text = _total.ToString();
            }
            else
            {
                _proCarSh.ToList().ForEach(p => p.TotalPrice = 0);
                _proCarSh.ToList().ForEach(p =>
                {
                    p.TotalPrice = p.TermPrice * Decimal.Parse(p.Amount.ToString());
                });

                dgShoppingCar.DataSource = _proCarSh;
                dgShoppingCar.Refresh();
                _total = _proCarSh.Sum(p => p.TotalPrice);
                txtTotal.Text = _total.ToString();
            }
        }
        #endregion

        #region btnPagar_Click
        private async void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Sale sale = new Sale()
                {
                    ClientId = Guid.Parse(txtClientId.Text),
                    EmployeeId = Guid.Parse(cbUsers.SelectedValue.ToString()),
                    Date = DateTime.UtcNow,
                    PercentageDiscount = Decimal.Parse(mtbPorcentageDiscount.Text),
                    CashDiscount = Decimal.Parse(mtbCashDiscount.Text),
                    AdditionCash = Decimal.Parse(mtbAdditionCash.Text),
                    AdditionPorcentage = Decimal.Parse(mtbAdditionPorcentage.Text),
                    Total = Decimal.Parse(txtTotal.Text),
                };

                if (_update)
                {
                   sale.Id = Guid.Parse(txtId.Text);
                }

                Guid.TryParse(cbUsers.SelectedValue.ToString(), out Guid employeeId);
                Guid.TryParse(txtClientId.Text, out Guid clientId);
                Client client = await ClientService.Get(clientId);
                Employee emp = await EmployeeService.Get(employeeId)
                    ?? throw new ArgumentNullException("Verifique se há um usuário selecionado para realizar a venda");
                frmPayment screen = new frmPayment(client, _proCarSh, emp, sale, _update);

                screen.ShowDialog();
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}