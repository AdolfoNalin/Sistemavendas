using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.br.pro.com.view;
using SistemaVenda.Model;
using SistemaVenda.Model.Helpers;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmAccountWriteOff : Form
    {
        public frmAccountWriteOff()
        {
            InitializeComponent();
        }

        private Client _client = null;
        private BindingList<Sale> _selectSales = new BindingList<Sale>();

        #region UpdateData
        private async void UpdateData()
        {
            try
            {

                BindingList<Sale> sales = await SaleService.GetOrderOpen(_client.Id) ?? 
                    throw new ArgumentNullException("Nenhuma venda encontrada!");

                txtOpen.Text = $"R${sales.Sum(s => s.Total)}";

                foreach (var s in sales)
                {
                    s.Client = await ClientService.Get(s.ClientId);
                    s.Employee = await EmployeeService.Get(s.EmployeeId);
                }

                dgAccountOff.DataSource = sales.Select(s =>
                new SaleDTO()
                {
                    Id = s.Id,
                    ClientName = s.Client.Name,
                    EmployeeName = s.Employee.Name,
                    Date = s.Date.Date,
                    PaymentMethod = s.PaymentMethod,
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

        #region txtClient_KeyDown
        private async void txtClient_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    string value = txtClient.Text;

                    List<Client> list = new List<Client>();

                    list = await ClientService.Get(value);

                    _client = list.FirstOrDefault() ?? 
                        throw new ArgumentNullException();
                }
            }
            catch(ArgumentNullException)
            {
                btnSearchClient_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnSearchClient_Click
        private async void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                frmClient screen = new frmClient();
                screen.btnCancel.Enabled = false;
                screen.btnDelete.Enabled = false;
                screen.btnNew.Enabled = false;
                screen.btnSave.Enabled = false;
                screen.btnUpdate.Enabled = false;

                screen.ShowDialog();

                Guid.TryParse(screen.dgClient.SelectedRows[0].Cells[0].Value.ToString(), out Guid id);

                _client = await ClientService.Get(id);
                txtClient.Text = _client.Name;
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

        #region btnUploadInstallment_Click
        private async void btnUploadInstallment_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region dgAccountOff_DoubleClick
        private async void dgAccountOff_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Guid id = ParseVerification.ParseGuid(dgAccountOff.SelectedRows[0].Cells[0].Value.ToString(), "Somente no formato Guid");
                BindingList<Sale>sales = await SaleService.Get(id) ??
                    throw new ArgumentNullException("Cliente não possue nenhuma divida");
                Sale sale = sales.FirstOrDefault();
                _selectSales.Add(sale);
                txtSelect.Text = $"R${_selectSales.Sum(s => s.Total)}";
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region frmAccountWriteOff_Load
        private void frmAccountWriteOff_Load(object sender, EventArgs e)
        {
            try
            {
                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Id",
                    HeaderText = "Código"
                });

                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ClientName",
                    HeaderText = "Cliente"
                });

                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Date",
                    HeaderText = "Data"
                });

                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "EmployeeName",
                    HeaderText = "Funcionário"
                });

                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "PaymentMethod",
                    HeaderText = "Forma de Pagamento"
                });

                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Total",
                    HeaderText = "Total"
                });

                dgAccountOff.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Observation",
                    HeaderText = "Observação"
                });


                dgAccountOff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgAccountOff.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region dgAccountOff_KeyDown
        private void dgAccountOff_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) 
                {
                    Helpers.UpOrDown(dg: dgAccountOff, e: e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnPayOff_Click
        private async void btnPayOff_Click(object sender, EventArgs e)
        {
            try
            {
                if(CashDesck.Status == IsCashSession.Open)
                {
                    frmPassword screenPassowrd = new frmPassword();
                    screenPassowrd.ShowDialog();

                    if (screenPassowrd.user.User != null)
                    {
                        Employee emp = await EmployeeService.Get(screenPassowrd.user.User.EmployeeId);

                        frmPayment screenPayment = new frmPayment(_client, _selectSales, emp);
                        screenPayment.ShowDialog();

                        UpdateData();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não foi encontrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Abra o caixa para receber a conta");
                }
               
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}
