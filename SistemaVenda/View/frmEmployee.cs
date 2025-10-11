using MySqlX.XDevAPI;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Service;
using SistemaVenda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmEmployee : Form
    {
        private bool _update = false;
        public frmEmployee()
        {
            InitializeComponent();
            UpdateData();
        }

        #region UpdateData
        private async void UpdateData()
        {
            List<Employee> emps =  await EmployeeService.Get();
          
            dgEmployee.DataSource = emps;
        }
        #endregion

        #region UpdateDetalis
        private void UpdateDetails()
        {
            try
            {
                Employee emp = null;
                if (dgEmployee.SelectedRows.Count > 0)
                {
                    emp = (Employee)dgEmployee.SelectedRows[0].DataBoundItem ??
                        throw new ArgumentNullException("Funcionário não foi selecionado");

                    txtId.Text = emp.Id.ToString() ?? throw new ArgumentNullException("ID não pode ser nulo");
                    txtName.Text = emp.Name.ToString() ?? throw new ArgumentNullException("Nome não pode nulo");
                    txtFunction.Text = emp.Function;
                    txtShortName.Text = emp.ShortName?.ToString();
                    mtbRG.Text = emp.RG?.ToString();
                    mtbCPF.Text = emp.CPF.ToString() ?? throw new ArgumentNullException("CPF não pode ser nulo");
                    cbMaritalStatus.Text = emp.MaritalStatus ?? throw new ArgumentException("Estado Civil é obrigatório!");
                    mtbPhoneNumber.Text = emp.PhoneNumber.ToString() ?? throw new ArgumentNullException("Celular não pode ser nulo");
                    mtbTelephoneNumber.Text = emp.TelephoneNumber?.ToString();
                    txtEmail.Text = emp.Email?.ToString();
                    mtbCEP.Text = emp.CEP ?? throw new ArgumentNullException("CEP não pode ser nulo");
                    txtStreet.Text = emp.Street.ToString() ?? throw new ArgumentNullException("Logradouro não pode ser nulo");
                    txtNumber.Text = emp.Number.ToString();
                    txtNeighborhood.Text = emp.Neighborhoods ?? throw new ArgumentNullException("Bairro não pode ser nulo");
                    txtCity.Text = emp.City.ToString() ?? throw new ArgumentNullException("Cidade não pode ser nulo");
                    cbUF.Text = emp.State.ToString() ?? throw new ArgumentNullException("Estado não pode ser nulo");
                    txtComplement.Text = emp.Complement?.ToString();
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

        #region dgEmployee_SelectionChanged
        private void dgEmployee_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }
        #endregion

        #region btnNew_click
        private void btnNew_Click(object sender, EventArgs e)
        {
            tabEmployee.SelectedTab = tpDetails;
            Helpers.ClearScreen(this);
            _update = false;

            if(!_update)
            {
                mtbCPF.Enabled = true;
                mtbRG.Enabled = true;
            }
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _update = true;
            txtId.Enabled = false;
            mtbCPF.Enabled = false;
            mtbRG.Enabled = false;
            tabEmployee.SelectedTab = tpDetails;
        }
        #endregion

        #region btnSave_click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    Name = txtName.Text ?? throw new ArgumentNullException("Nome do Funcionário não pode ser vázio", "Atenção"),
                    ShortName = txtShortName.Text,
                    CPF = mtbCPF.Text ?? throw new ArgumentNullException("CPF não pode ser vázio", "Atenção"),
                    RG = mtbRG.Text.Count() == 10 ? null : mtbRG.Text,
                    TelephoneNumber = mtbTelephoneNumber.Text.Count() == 11 ? null : mtbTelephoneNumber.Text,
                    MaritalStatus = cbMaritalStatus.Text ?? throw new ArgumentNullException("Estado Civil não pode ser vazio", "Atenção"),
                    PhoneNumber = mtbPhoneNumber.Text ?? throw new ArgumentNullException("Número de celular não pode ser vázio"),
                    Email = txtEmail.Text,
                    CEP = mtbCEP.Text ?? throw new ArgumentNullException("CEP não pode ser vazio!", "Atenção"),
                    State = cbUF.Text ?? throw new ArgumentNullException("Estado não pode ser vazio", "Atenção"),
                    City = txtCity.Text ?? throw new ArgumentNullException("Cidade não pode ser vazio", "Atenção"),
                    Street = txtStreet.Text ?? throw new ArgumentNullException("Logradouro não pode ser vazio", "Atenção"),
                    Neighborhoods = txtNeighborhood.Text ?? throw new ArgumentNullException("Bairro não pode ser vazio", "Atenção"),
                    Number = int.Parse(txtNumber.Text ?? throw new ArgumentNullException("Numero não pode ser vazio", "Atenção")),
                    Complement = txtComplement.Text,
                    Function = txtFunction.Text ?? throw new ArgumentNullException("Função não pode ser vazio", "Atenção"),
                }; 

                if (employee is null)
                {
                    throw new ArgumentException("Funcionário é nulo");
                }

                if (_update)
                {
                    employee.Id = Guid.Parse(txtId.Text ?? throw new ArgumentNullException("Código é nulo, verifique o Funcionário"));
                    EmployeeService.Put(employee);
                }
                else
                {
                    EmployeeService.Post(employee);
                }

                await Task.Delay(1500);
                UpdateData();
                
                tabEmployee.SelectedTab = tpConsult;
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region btnSearch_Click
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await Task.Delay(800);

            try
            {
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    List<Employee> employees = await EmployeeService.Get();
                    await Task.Delay(800);
                    dgEmployee.DataSource = employees;
                }
                else
                {
                    List<Employee> employees = await EmployeeService.Get(txtSearch.Text);
                    await Task.Delay(1500);
                    dgEmployee.DataSource = employees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region btnExit_click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnCancel_Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tabEmployee.SelectedTab = tpConsult;
            UpdateData();
        }
        #endregion

        #region mtbCEP_KeyPress
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cbUF.Items.Clear();

                    City city = SearchCEP.SearchCity(mtbCEP.Text);

                    if (city is null)
                    {
                        throw new ArgumentNullException("Cidade não encontrada!!");
                    }
                    else
                    {
                        cbUF.Text = city.UF;
                        txtCity.Text = city.Name;
                        txtNeighborhood.Text = city.Neighborhood;
                        txtStreet.Text = city.Street;
                    }
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

        #region btnAuthorizations_Click
        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            frmScreenAuthorization screen = new frmScreenAuthorization();
            screen.ShowDialog();
        }
        #endregion

        #region txtSearch_KeyPress
        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            await Task.Delay(800);

            try
            {
                if (String.IsNullOrEmpty(txtSearch.Text))
                {
                    List<Employee> employees = await EmployeeService.Get();
                    await Task.Delay(800);
                    dgEmployee.DataSource = employees;
                }
                else
                {
                    List<Employee> employees = await EmployeeService.Get(txtSearch.Text);
                    await Task.Delay(1500);
                    dgEmployee.DataSource = employees;
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
            Guid.TryParse(txtId.Text, out Guid id);
            EmployeeService.Delete(id);

            await Task.Delay(1500);
            UpdateData();
            tabEmployee.SelectedTab = tpConsult;
        }
        #endregion

        #region Load
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "Código"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Nome"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "ShortName",
                HeaderText = "Apelido"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "CPF",
                HeaderText = "CPF"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "RG",
                HeaderText = "RG"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "MaritalStatus",
                HeaderText = "Estado Civil"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Function",
                HeaderText = "Função"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "DueDate",
                HeaderText = "Data de Nascimento"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "PhoneNumber",
                HeaderText = "Celular"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "TelephoneNumber",
                HeaderText = "Telefone"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "CEP",
                HeaderText = "CEP"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "State",
                HeaderText = "Estado"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "City",
                HeaderText = "Cidade"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Neighborhoods",
                HeaderText = "Bairro"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Street",
                HeaderText = "Rua"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Number",
                HeaderText = "Número"
            });

            dgEmployee.Columns.Add(new DataGridViewColumn()
            {
                DataPropertyName = "Complement",
                HeaderText = "Complemento"
            });
        }
        #endregion
    }
}
