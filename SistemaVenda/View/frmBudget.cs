using SistemaVenda.Service;
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
using SistemaVenda.Model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.View;
using SistemaVenda.Model.Helpers;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmBudget : Form
    {
        public frmBudget()
        {
            InitializeComponent();
        }

        private decimal _total = 0;

        private BindingList<ProductShoppingCar> _car = new BindingList<ProductShoppingCar>();
        private bool _update = false;
        private Budget _budget = new Budget();

        #region btnAdd_Click
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = await ProductService.Get(txtProduct.Text);
                Product product = products.FirstOrDefault() ??
                    throw new ArgumentException("Descrilção inválida", "Nenhum produto encontrado");

                ProductShoppingCar productCar = new ProductShoppingCar()
                {
                    ShortDescription = product.ShortDescription,
                    CashPrice = product.CashPrice,
                    TermPrice = product.TermPrice,
                    Amount = Double.Parse(txtAmount.Text.ToString()),
                    TotalPrice = rbCash.Checked ? product.CashPrice * Decimal.Parse(txtAmount.Text) : product.TermPrice * Decimal.Parse(txtAmount.Text)
                };

                _car.Add(productCar);
                txtTotal.Text = _car.Sum(x => x.TotalPrice).ToString();
                dgShoppingCar.DataSource = _car;

                txtProduct.Clear();
                txtAmount.Clear();
                
                txtProduct.Focus();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }

        }
        #endregion

        #region UpdateCashOrTerm
        private void UpdateCashOrTerm()
        {
            try
            {
                dgShoppingCar.Rows.Clear();

                if(rbCash.Checked)
                {
                    _budget.PaymentMethod = "A Vista";

                    _car.ToList().ForEach(c => c.TotalPrice = 0);
                    _car.ToList().ForEach(c =>
                    c.TotalPrice = Decimal.Parse(c.Amount.ToString()) * c.CashPrice
                    );

                    txtTotal.Text = _car.Sum(c => c.TotalPrice).ToString();
                    
                    dgShoppingCar.DataSource = _car;
                }
                else
                {
                    _budget.PaymentMethod = "A Prazo";

                    _car.ToList().ForEach(c => c.TotalPrice = 0);
                    _car.ToList().ForEach(c =>
                    c.TotalPrice = Decimal.Parse(c.Amount.ToString()) * c.CashPrice
                    );

                    txtTotal.Text = _car.Sum(c => c.TotalPrice).ToString();

                    dgShoppingCar.DataSource = _car;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Load
        private async void frmBudget_Load(object sender, EventArgs e)
        {
            UpdateData();

            rbCash.Checked = true;  

            mtbDate.Text = DateTime.Now.ToString("dd/M/yyyy");

            mtbAdditionCash.Text = "0.00";
            mtbCashDiscount.Text = "0.00";
            mtbAdditionPorcentage.Text = "0.00";
            txtTotal.Text = "0.00";

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "id",
                HeaderText = "Código"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ClientId",
                HeaderText = "Cliente"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EmployeeId",
                HeaderText = "Funcionário"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "Forma de pagamento"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DescountPercentage",
                HeaderText = "Desconto Porcentagem"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CashDescount",
                HeaderText = "Desconto Dinheiro"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AdditionPorcentage",
                HeaderText = "Adicionar Procetagen"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AdditionCash",
                HeaderText = "Adicionar Dinheiro"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Total",
                HeaderText = "Total"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Date",
                HeaderText = "Data"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AmountItens",
                HeaderText = "Quantidade de Itens"
            });

            dgBudget.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Obs",
                HeaderText = "Observação"
            });

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
        }
        #endregion

        #region UpdateData
        private async void UpdateData()
        {
            try
            {
                dgBudget.DataSource = await BudgetService.Get()
                    ?? throw new ArgumentNullException("Nenhum Orçamento encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }

        }
        #endregion

        #region UpdateDetails
        private async void UpdateDetails()
        {
            if(dgBudget.Rows.Count > 0)
            {
                _budget = dgBudget.SelectedRows[0].DataBoundItem as Budget;
                
                Client client = await ClientService.Get(_budget.ClientId);

                txtClientId.Text = _budget.ClientId.ToString();
                txtName.Text = client.Name;
                mtbDate.Text = _budget.Date.ToString("dd/mm/yyyy");
                mtbAdditionCash.Text = _budget.AdditionCash.ToString();
                mtbAdditionPorcentage.Text = _budget.AdditionPorcentage.ToString();
                mtbCashDiscount.Text = _budget.CashDescount.ToString();
                mtbPercentageDiscount.Text = _budget.DescountPercentage.ToString();
                txtTotal.Text = _budget.Total.ToString();

                _ = _budget.PaymentMethod == "A vista" ? rbCash.Checked = true : rbTerm.Checked = true; 

                dgShoppingCar.DataSource = await ItemBudgetService.Get(_budget.Id);  
            }
        }
        #endregion

        #region btnConsultClient
        private void btnConsultClient_Click(object sender, EventArgs e)
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
                Client client = (Client)screen.dgClient.SelectedRows[0].DataBoundItem;
                txtName.Text = client.Name;
                txtClientId.Text = client.Id.ToString();
                screen.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region dgBudget_SelectionChanged
        private void dgBudget_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }
        #endregion

        #region txtSearch_KeyDown
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnSearch_Click
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    throw new ArgumentNullException("Atenção", "O valor de pesquisa está vazio");
                }
                else
                {
                    dgBudget.DataSource = await BudgetService.Get(txtSearch.Text);
                }
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
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
            this.Hide();
        }
        #endregion

        #region btnNew_Click
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                _update = false;
                Helpers.ClearScreen(this);

                tabBudget.SelectedTab = tpDetails;
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
            try
            {
                if (dgBudget.SelectedRows.Count > 0)
                {
                    _update = true;
                    tabBudget.SelectedTab = tpDetails;
                }
                else
                {
                    MessageBox.Show("Selecione uma lina na tabela");
                }

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
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user != null)
                {
                    if (dgBudget.SelectedRows.Count > 0)
                    {
                        await BudgetService.Delete(_budget.Id);
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma lista na tabela");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnSave_Click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user != null)
                {
                    BindingList<ProductShoppingCar> car = dgBudget.DataSource as BindingList<ProductShoppingCar>;

                    _budget = new Budget()
                    {
                        ClientId = Guid.Parse(txtClientId.Text),
                        EmployeeId = UserSession.EmployeeId,
                        Date = DateTime.UtcNow,
                        DescountPercentage = Convert.ToDecimal(mtbPercentageDiscount.Text),
                        CashDescount = Convert.ToDecimal(mtbCashDiscount.Text),
                        AdditionCash = Convert.ToDecimal(mtbAdditionCash.Text),
                        AdditionPorcentage = Convert.ToDecimal(mtbAdditionPorcentage.Text),
                        Total = Convert.ToDecimal(txtTotal.Text)
                    };

                    if (_update)
                    {
                        _budget.Id = Guid.Parse(txtId.Text);

                        bool value = await BudgetService.Put(_budget);

                        if (value)
                        {
                            foreach (var i in car)
                            {
                                ItemBudget item = new ItemBudget();
                                List<Product> products = await ProductService.Get(i.ShortDescription);
                                Product product = products.FirstOrDefault() ??
                                    throw new ArgumentNullException("Produto não encontrado");

                                item.BudgetId = _budget.Id;
                                item.ProductId = product.Id;
                                item.Amount = i.Amount;
                                item.Subtotal = i.TotalPrice;

                                ItemBudgetService.Put(item);
                            }

                            MessageBox.Show("Orçamento atudalizado com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Orçamento não foi atualizado");
                        }
                    }
                    else
                    {
                        Guid budgetId = await BudgetService.GetLastBudget();

                        bool value = await BudgetService.Post(_budget);

                        if (value)
                        {
                            foreach (var i in car)
                            {
                                ItemBudget item = new ItemBudget();
                                List<Product> products = await ProductService.Get(i.ShortDescription);
                                Product product = products.FirstOrDefault() ??
                                    throw new ArgumentNullException("Produto não encontrado");

                                item.BudgetId = _budget.Id;
                                item.ProductId = product.Id;
                                item.Amount = i.Amount;
                                item.Subtotal = i.TotalPrice;

                                ItemBudgetService.Post(item);
                            }

                            MessageBox.Show("Orçamento cadastrado com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Orçamento não foi salvo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                tabBudget.SelectedTab = tpConsult;
                UpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnRemove_Click
        private async void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgShoppingCar.SelectedRows.Count > 0)
                {
                    ProductShoppingCar proSh = dgShoppingCar.SelectedRows[0].DataBoundItem as ProductShoppingCar;
                    _car.Remove(proSh);
                    decimal total = Decimal.Parse(txtTotal.Text);
                    total -= proSh.TotalPrice;
                    txtTotal.Text = total.ToString();

                    dgShoppingCar.DataSource = _car;
                }
                else
                {
                    MessageBox.Show("Selecrione uma linha na tabela");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region txtAmount_KeyDown
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnConsultProduct_Click
        private void btnConsultProduct_Click(object sender, EventArgs e)
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

                Product product = screen.dgProduct.SelectedRows[0].DataBoundItem as Product;
                txtProduct.Text = product.ShortDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region mtbDD_KeyDown
        private void mtbDD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbCashDiscount.Text.Equals("0") || mtbCashDiscount.Text == String.Empty)
                    {
                        _total = _car.Sum(p => p.TotalPrice);
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
                throw;
            }
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
        #endregion

        #region mtbAD_KeyDown
        private void mtbAD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbAdditionCash.Text.Equals("0") || mtbAdditionCash.Text == String.Empty)
                    {
                        _total = _car.Sum(p => p.TotalPrice);
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
                throw;
            }
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
        #endregion

        #region mtbDP_KeyDown
        private void mtbDP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (mtbPercentageDiscount.Text.Equals("0") || mtbPercentageDiscount.Text == String.Empty)
                {
                    _total = _car.Sum(c => c.TotalPrice);
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
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                throw;
            }
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
        #endregion

        #region mtbAP_KeyDown
        private void mtbAP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (mtbAdditionPorcentage.Text.Equals("0") || mtbAdditionPorcentage.Text == String.Empty)
                    {
                        _total = _car.Sum(p => p.TotalPrice);
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
                throw;
            }
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
        #endregion

        #region rbCash_CheckedChanged
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCashOrTerm();
        }
        #endregion

        #region rbTerm_CheckedChanged
        private void rbTerm_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCashOrTerm();
        }
        #endregion
    }
}
