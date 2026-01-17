using SistemaVenda.View;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVenda.Service;
using SistemaVenda.Model;
using MySql.Data.MySqlClient;
using System.Threading;
using SistemaVenda.Model.Helpers;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmClient : Form
    {
        private bool _update = false;

        public frmClient()
        {
            InitializeComponent();
            UpdateData();
        }

        #region UpdateData
        private async void UpdateData()
        {
            try
            {
                List<Client> clients = null;
                clients = await ClientService.Get() ??
                    throw new ArgumentNullException("Nenhum cliente cadastrado");
                dgClient.DataSource = clients.Select(c =>
                new ClientDTO()
                {
                    Id = c.Id,
                    Name = c.Name,
                    CPF = c.CPF,
                    Email = c.Email,
                    Credit = c.Credit,
                    CEP = c.CEP,
                    State = c.State,
                    City = c.City,
                    Neighborhoods = c.Neighborhoods,
                    Street = c.Street,
                    Number = c.Number,
                    Complement = c.Complement
                }).ToList();
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

        #region UpdateDetails
        private async Task UpdateDetails()
        {
            try
            {
                if (dgClient.SelectedRows.Count > 0)
                {
                    Guid.TryParse(dgClient.SelectedRows[0].Cells[0].Value.ToString(), out Guid Id);

                    Client client = await ClientService.Get(Id) ?? 
                        throw new ArgumentNullException("Cliente não foi selecionado");

                    txtId.Text = client.Id.ToString() ?? throw new ArgumentNullException("ID não pode ser nulo");
                    txtNome.Text = client.Name.ToString() ?? throw new ArgumentNullException("Nome não pode nulo");
                    txtApelido.Text = client.ShortName?.ToString();
                    mtbRG.Text = client.RG?.ToString();
                    mtbCPF.Text = client.CPF.ToString() ?? throw new ArgumentNullException("CPF não pode ser nulo");
                    cbEstadoCivil.Text = client.MaritalStatus ?? throw new ArgumentException("Estado Civil é obrigatório!");
                    mtbCelular.Text = client.PhoneNumber.ToString() ?? throw new ArgumentNullException("Celular não pode ser nulo");
                    mtbTelefone.Text = client.TelephoneNumber?.ToString();
                    txtEmail.Text = client.Email?.ToString();
                    mtbCEP.Text = client.CEP ?? throw new ArgumentNullException("CEP não pode ser nulo");
                    txtLogradouro.Text = client.Street.ToString() ?? throw new ArgumentNullException("Logradouro não pode ser nulo");
                    txtNumero.Text = client.Number.ToString();
                    txtBairro.Text = client.Neighborhoods ?? throw new ArgumentNullException("Bairro não pode ser nulo");
                    txtCidade.Text = client.City.ToString() ?? throw new ArgumentNullException("Cidade não pode ser nulo");
                    cbUF.Text = client.State.ToString() ?? throw new ArgumentNullException("Estado não pode ser nulo");
                    txtComplemento.Text = client.Complement?.ToString();
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

        #region Load
        private void frmClient_Load(object sender, EventArgs e)
        {
            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "Código"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Nome"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CPF",
                HeaderText = "CPF"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Credit",
                HeaderText = "Crediário"
            });


            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CEP",
                HeaderText = "CEP"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "State",
                HeaderText = "Estado"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "City",
                HeaderText = "Cidade"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Neighborhoods",
                HeaderText = "Bairro"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Street",
                HeaderText = "Rua"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Number",
                HeaderText = "Número"
            });

            dgClient.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Complement",
                HeaderText = "Complemento"
            });

            dgClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClient.MultiSelect = false;
        }
        #endregion

        #region txtSearch_KeyPress
        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string value = ParseVerification.ParseString(txtSearch.Text, "Pesquisa não pode ser vazio");

                List<Client> clients = await ClientService.Get(value);
                await Task.Delay(1000);
                dgClient.DataSource = clients;
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
            _update = false;

            Helpers.ClearScreen(this);

            mtbCPF.Enabled = true;
            tabClient.SelectedTab = tpDetails;
        }
        #endregion

        #region btnUpdate_Click
        private async void btnUpdate_Click(object sender, EventArgs e)
        {

            _update = true;
            mtbCPF.Enabled = false;
            mtbRG.Enabled = false;
            txtId.Enabled = false;
            txtCreditLimit.Enabled = false;
            await UpdateDetails();
            tabClient.SelectedTab = tpDetails;
        }
        #endregion

        #region btnCancel_click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
            tabClient.SelectedTab = tpConsult;
        }
        #endregion

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //uid.TryParse(txtId.Text, out Guid id);

            frmPassword screen = new frmPassword();
            screen.ShowDialog();

            if(screen.user.User !=  null)
            {
                Client client = dgClient.SelectedRows[0].DataBoundItem as Client;
                ClientService.Delete(client.Id);

                await Task.Delay(1500);
                UpdateData();
                tabClient.SelectedTab = tpConsult;
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

                if(screen.user.User != null)
                {
                    Client obj = new Client();

                    DateTime.TryParse(mtbDueDate.Text, out DateTime dt);

                    obj.Name = txtNome.Text ?? throw new ArgumentNullException("Verifique se o nome não é nulo");
                    obj.ShortName = txtApelido?.Text;
                    obj.CPF = mtbCPF.Text ?? throw new ArgumentNullException("Verifique se o CPF não é nulo");
                    obj.RG = mtbRG?.Text.Count() == 11 ? null : mtbRG.Text;
                    obj.DueDate = dt.ToUniversalTime();
                    obj.Credit = ParseVerification.ParseDecimal(txtCredit.Text, "Limite de crediário não pode ser nulo");
                    obj.Email = txtEmail?.Text;
                    obj.MaritalStatus = cbEstadoCivil.Text ?? throw new ArgumentNullException("Verifique se o Estado civil é nulo");
                    obj.PhoneNumber = mtbCelular.Text ?? throw new ArgumentNullException("Verifique se o Número não é nulo");
                    obj.TelephoneNumber = mtbTelefone?.Text.Count() == 10 ? null : mtbTelefone.Text;
                    obj.CEP = mtbCEP.Text ?? throw new ArgumentNullException("Verifique se o CEP não é nulo");
                    obj.Street = txtLogradouro.Text ?? throw new ArgumentNullException("Verifique se Logradouro não é nulo");
                    obj.Number = int.Parse(txtNumero.Text ?? throw new ArgumentNullException("Verifique se o Número não é nulo"));
                    obj.Complement = txtComplemento?.Text;
                    obj.Neighborhoods = txtBairro.Text ?? throw new ArgumentNullException("Verifique se o Bairro não é nulo");
                    obj.City = txtCidade.Text ?? throw new ArgumentNullException("Verifique se a Cidade não é nulo");
                    obj.State = cbUF.Text ?? throw new ArgumentNullException("Verifique se as Siglas não são nulas");


                    if (obj is null)
                    {
                        throw new NullReferenceException("Clinte está nulo, impossivel salvar");
                    }

                    if (_update)
                    {
                        obj.Id = Guid.Parse(txtId.Text ?? throw new ArgumentNullException("Código é nulo, verifique o cliente"));
                        ClientService.Put(obj);
                        await Task.Delay(3000);
                        UpdateData();
                        tabClient.SelectedTab = tpConsult;
                    }
                    else
                    {
                        ClientService.Post(obj);
                        await Task.Delay(3000);
                        UpdateData();
                        tabClient.SelectedTab = tpConsult;
                    }
                }
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch(ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region mtbCEP_KeyPress
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    City city = SearchCEP.SearchCity(mtbCEP.Text);

                    if (city != null)
                    {
                        txtCidade.Text = city.Name;
                        txtLogradouro.Text = city.Street;
                        txtBairro.Text = city.Neighborhood;
                        cbUF.Text = city.UF;
                        txtComplemento.Text = city.Complement;
                    }
                }
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

        #region dgClient_KeyDown
        private void dgClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                Helpers.UpOrDown(e, dgClient);
            }
            else if(e.KeyCode == Keys.Enter) 
            {
                UpdateDetails();
                tabClient.SelectedTab = tpDetails;
            }
        }
        #endregion
    }
}
