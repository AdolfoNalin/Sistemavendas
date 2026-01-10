using Microsoft.Extensions.Logging;
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
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private BindingList<ProductShoppingCar> _proCarSh = new BindingList<ProductShoppingCar>();
        private decimal _total;
        private bool _update = false;
        private Client _client;
        private int _countUpdate = 0;

        #region UpdateDetails
        private async void UpdateDetails()
        {
            try
            {
                if (dgSale.SelectedRows.Count > 0)
                {
                    Guid.TryParse(dgSale.SelectedRows[0].Cells[0].Value.ToString(), out Guid id);

                    BindingList<Sale> sales = await SaleService.Get(id);

                    Sale sale = sales.FirstOrDefault();
                    sale.Client = await ClientService.Get(sale.ClientId);
                    sale.Employee = await EmployeeService.Get(sale.EmployeeId);

                    BindingList<ItemSale> itens = await ItemSaleService.Get(sale.Id);

                    string address = Helpers.Address(sale.Client);

                    txtId.Text = sale.Id.ToString();
                    txtClientId.Text = sale.Client.Id.ToString();
                    txtName.Text = sale.Client.Name;
                    mtbCPF.Text = sale.Client.CPF;
                    mtbDate.Text = sale.Date.Date.ToString("dd/MM/yyyy");
                    txtAddress.Text = address;
                    mtbPhone.Text = sale.Client.PhoneNumber;
                    mtbAdditionCash.Text = sale.AdditionCash.ToString();
                    mtbAdditionPorcentage.Text = sale.AdditionPorcentage.ToString();
                    mtbCashDiscount.Text = Convert.ToString(sale.CashDiscount);
                    mtbPercentageDiscount.Text = sale.PercentageDiscount.ToString();
                    txtTotal.Text = sale.Total.ToString();

                    User user = await UserService.GetEmployee(sale.Employee.Id);

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
        private async void UpdateData()
        {
            BindingList<Sale> sales = await SaleService.Get();
            foreach(var s in sales)
            {
                s.Employee = await EmployeeService.Get(s.EmployeeId);
                s.Client = await ClientService.Get(s.ClientId);
            }

            dgSale.DataSource = sales.Select(s => new SaleDTO
            { 
                Id = s.Id,
                ClientName = s.Client.Name,
                EmployeeName = s.Employee.Name,
                PaymentMethod = s.PaymentMethod,
                Date = s.Date,
                Total = s.Total,
                Observation = s.Observation
            }).ToList();

        }
        #endregion

        #region SearchCPF
        private async void SearchCPF()
        {
            try
            {
                List<Client> list = await ClientService.Get(mtbCPF.Text);

                _client = list.FirstOrDefault() ?? 
                    throw new ArgumentNullException("Cliente não foi encontrado", "ATENÇÃO");

                txtClientId.Text = _client.Id.ToString();
                txtName.Text = _client.Name;
                mtbCPF.Text = _client.CPF;
                mtbPhone.Text = _client.PhoneNumber;
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

        #region Laod
        private async void frmSale_Load(object sender, EventArgs e)
        {
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

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "Código"
            });

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ClientName",
                HeaderText = "Cliente"
            });

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Date",
                HeaderText = "Data"
            });

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EmployeeName",
                HeaderText = "Funcionário"
            });

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "Forma de Pagamento"
            });

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Total",
                HeaderText = "Total"
            });

            dgSale.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Observation",
                HeaderText = "Observação"
            });

            UpdateData();

            rbtnSport.Checked = true;

            dgShoppingCar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgShoppingCar.MultiSelect = false;

            dgSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSale.MultiSelect = false;
        }
        #endregion

        #region btnNew
        private void btnNew_Click(object sender, EventArgs e)
        {
            _update = false;
            dgShoppingCar.Rows.Clear();
            Helpers.ClearScreen(this);
            mtbCPF.Text = "000.000.000-00";
            txtName.Text = "Consumidor";
            mtbAdditionCash.Text = "0.00";
            mtbAdditionPorcentage.Text = "0.00";
            mtbCashDiscount.Text = "0.00";
            mtbPercentageDiscount.Text = "0.00";
            tabSale.SelectedTab = tpDetails;
            mtbDate.Text = DateTime.Now.ToString();
            txtAddress.Clear();
        }
        #endregion

        #region btnSearchName_click
        private async void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                frmClient screen = new frmClient();
                screen.btnNew.Enabled = false;
                screen.btnCancel.Enabled = false;
                screen.btnSave.Enabled = false;
                screen.btnUpdate.Enabled = false;
                screen.btnDelete.Enabled = false;
                screen.ShowDialog();

                Guid.TryParse(screen.dgClient.SelectedRows[0].Cells[0].Value.ToString(), out Guid Id);

                Client client = await ClientService.Get(Id);

                if (client is null)
                {
                    throw new ArgumentNullException("Cliente não foi selecionado");
                }
                else
                {
                    txtClientId.Text = client.Id.ToString();
                    mtbCPF.Text = client.CPF;
                    txtName.Text = client.Name;
                    mtbPhone.Text = client.PhoneNumber;
                    txtAddress.Text = Helpers.Address(client);
                }

                    screen.Hide();
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
                        Amount = Double.Parse(txtAmount.Text ?? throw new ArgumentNullException("Quantidade não pode ser vázia")),
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
            catch (FormatException)
            {
                MessageBox.Show("Quantidade não pode ser vazia");
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

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            frmPassword screen = new frmPassword();
            screen.ShowDialog();

            if (screen.user.User != null)
            {
                if (dgSale.SelectedRows.Count > 0)
                {
                    Guid.TryParse(dgSale.SelectedRows[0].Cells[0].Value.ToString(), out Guid id);
                    SaleService.Delete(id);
                    await Task.Delay(800);
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Selecione a venda na tabela");
                }
            }
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if (screen.user.User != null)
                {
                    _proCarSh.Clear();

                    _update = true;
                    UpdateDetails();
                    tabSale.SelectedTab = tpDetails;
                }
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

        #region txtSearch_KeyDown
        private async void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                BindingList<Sale> sales = await SaleService.Get();
                foreach (var s in sales)
                {
                    s.Employee = await EmployeeService.Get(s.EmployeeId);
                    s.Client = await ClientService.Get(s.ClientId);
                }

                dgSale.DataSource = sales.Select(s => new SaleDTO
                {
                    Id = s.Id,
                    ClientName = s.Client.Name,
                    EmployeeName = s.Employee.Name,
                    PaymentMethod = s.PaymentMethod,
                    Date = s.Date,
                    Total = s.Total,
                    Observation = s.Observation
                }).Where(s => s.ClientName.ToUpper().Contains(txtSearch.Text.ToUpper()) ||
                s.EmployeeName.ToUpper().Contains(txtSearch.Text.ToUpper())
                ).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    if (mtbPercentageDiscount.Text.Equals("0") || mtbPercentageDiscount.Text == String.Empty)
                    {
                        _total = _proCarSh.Sum(c => c.TotalPrice);
                        txtTotal.Clear();
                        txtTotal.Text = _total.ToString();
                        mtbCashDiscount.Text = "0.00";
                    }
                    else
                    {
                        _total = Convert.ToDecimal(txtTotal.Text);

                        Decimal.TryParse(mtbPercentageDiscount.Text, out decimal value);
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
                        mtbPercentageDiscount.Text = "0.00";
                    }
                    else
                    {
                        Decimal.TryParse(mtbCashDiscount.Text, out decimal value);
                        decimal result = Calculator.Cash(total: _total, value: value);
                        mtbPercentageDiscount.Text = result.ToString();
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
                if (CashDesck.Status == IsCashSession.Open) 
                {
                    Client client = await ClientService.Get(ParseVerification.ParseGuid(txtClientId.Text, "Selecione o cliente"));
                    if (_total < client.Credit)
                    {
                        Sale sale = new Sale()
                        {
                            CashId = CashDesck.Id,
                            ClientId = client.Id,
                            EmployeeId = Guid.Parse(cbUsers.SelectedValue.ToString()),
                            Date = DateTime.UtcNow,
                            PercentageDiscount = Convert.ToDecimal(mtbPercentageDiscount.Text),
                            CashDiscount = Convert.ToDecimal(mtbCashDiscount.Text),
                            AdditionCash = Convert.ToDecimal(mtbAdditionCash.Text),
                            AdditionPorcentage = Convert.ToDecimal(mtbAdditionPorcentage.Text),
                            Total = ParseVerification.ParseDecimal(txtTotal.Text, "")
                        };

                        if (_update)
                        {
                            sale.Id = Guid.Parse(txtId.Text);
                        }

                        Guid.TryParse(cbUsers.SelectedValue.ToString(), out Guid employeeId);
                        Guid.TryParse(txtClientId.Text, out Guid clientId);
                        Employee emp = await EmployeeService.Get(employeeId)
                            ?? throw new ArgumentNullException("Verifique se há um usuário selecionado para realizar a venda");

                        frmPayment screen = new frmPayment(client, _proCarSh, emp, sale, _update);
                        this.Hide();
                        screen.ShowDialog();
                        btnCancelar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Limite do cliente estourou");
                    }
                }
                else
                {
                    MessageBox.Show("Abra o caixa, para conseguir realizar a venda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnSearchProduct_Click
        private async void btnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                frmProduct screen = new frmProduct();
                screen.btnNew.Enabled = false;
                screen.btnCancel.Enabled = false;
                screen.btnSave.Enabled = false;
                screen.btnUpdate.Enabled = false;
                screen.btnDelete.Enabled = false;
                screen.ShowDialog();

                Guid productId = Guid.Parse(screen.dgProduct.SelectedRows[0].Cells[0].Value.ToString());
                
                Product product = await ProductService.Get(productId); 

                if (product != null)
                {
                    txtShortDescription.Text = product.ShortDescription;
                    txtTermPrice.Text = product.TermPrice.ToString();
                    txtSpotPrice.Text = product.CashPrice.ToString();
                    txtStock.Text = product.Amount.ToString();
                    txtProductId.Text = product.Id.ToString();

                    txtAmount.Focus();
                }
                else
                {
                    MessageBox.Show("Nenhum produto foi selecionado");
                }

                screen.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region dgSale_KeyDown
        private void dgSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgSale = Helpers.UpOrDown(e, dgSale);
            }
            else
            {
                UpdateDetails();
                btnUpdate_Click(sender, e);
            }
        }
        #endregion

        #region dgShoppingCar_KeyDown
        private void dgShoppingCar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dgShoppingCar = Helpers.UpOrDown(e, dgShoppingCar);
            }
        }
        #endregion

        #region btnPesquisarCliente_Click
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCPF();   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbCPF_KeyDown
        private void mtbCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCPF();
            }
        }
        #endregion

        #region btnSearchDate_Click
        private async void btnSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<Sale> sales = await SaleService.Get(startDate: dtpStartDate.Text, endDate: dtpEndDate.Text);

                foreach (var s in sales)
                {
                    s.Employee = await EmployeeService.Get(s.EmployeeId);
                    s.Client = await ClientService.Get(s.ClientId);
                }

                dgSale.DataSource = sales.Select(s => new SaleDTO
                {
                    Id = s.Id,
                    ClientName = s.Client.Name,
                    EmployeeName = s.Employee.Name,
                    PaymentMethod = s.PaymentMethod,
                    Date = s.Date,
                    Total = s.Total,
                    Observation = s.Observation
                }).ToList();
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}