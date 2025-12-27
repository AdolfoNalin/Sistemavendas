using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.View
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private List<String> authorizations = null;
        private bool _update = false;

        #region UpdateData
        private async void UpdateData()
        {
            List<User> users = await UserService.Get() ?? throw new ArgumentNullException("Nenhum Usuário encontrado!");

            users.ToList().ForEach(async u =>
            {
                u.Employee = await EmployeeService.Get(u.EmployeeId);
            });

            dgUser.DataSource = users.Select(u => new
            {
                Id = u.Id,
                Name = u.Name,
                Login = u.Login,
                Authorizations = u.Authorizations,
            }).ToList();
        }
        #endregion

        #region UpdateDetails
        private async void UpdateDetails()
        {
            if(dgUser.SelectedRows.Count > 0)
            {
                Guid.TryParse(dgUser.SelectedRows[0].Cells[0].Value.ToString(), out Guid id);

                User user = await UserService.Get(id);

                txtId.Text = user.Id.ToString();
                txtNome.Text = user.Name;
                txtApelido.Text = user.Login;
                txtPassword.Text = user.Password;

                Employee emp = await EmployeeService.Get(user.EmployeeId);
                cbEmployees.Text = emp.Name; 
            }
        }
        #endregion

        #region frmUser_Load
        private async void frmUser_Load(object sender, EventArgs e)
        {
            cbEmployees.DataSource = await EmployeeService.Get();
            cbEmployees.ValueMember = "id";
            cbEmployees.DisplayMember = "name";

            dgUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "Código"
            });

            dgUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Funcionário"
            });

            dgUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Authorizations",
                HeaderText = "Autorizações"
            });

            UpdateData();

            dgUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUser.AllowUserToAddRows = false;
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _update = true;
            txtId.Enabled = false;
            tabUser.SelectedTab = tpDetails;
        }
        #endregion

        #region btnNew_Click
        private void btnNew_Click(object sender, EventArgs e)
        {
            _update = false;
            Helpers.ClearScreen(this);
            tabUser.SelectedTab = tpDetails;
        }
        #endregion

        #region btnDelete_Click
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user.User != null)
                {
                    if (dgUser.SelectedRows.Count > 0)
                    {
                        User user = (User)dgUser.SelectedRows[0].DataBoundItem;

                        UserService.Delete(user.Id);
                        await Task.Delay(1000);
                        UpdateData();
                        tabUser.SelectedTab = tpConsult;
                    }
                    else
                    {
                        throw new NullReferenceException("Usuário não existe para ser deletedo!");
                    }
                }
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Save_click
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassword screen = new frmPassword();
                screen.ShowDialog();

                if(screen.user.User != null)
                {
                    User user = new User()
                    {
                        Name = txtNome.Text ?? throw new ArgumentNullException("Nome precisa ser preenchido"),
                        Login = txtApelido.Text ?? throw new ArgumentNullException("Login precisa ser preenchido"),
                        EmployeeId = Guid.Parse(cbEmployees.SelectedValue.ToString() ?? throw new ArgumentNullException("Usuário precisa de um funcionário")),
                        Password = txtPassword.Text ?? throw new ArgumentNullException("Usuário precisa de uma senha"),
                        Authorizations = frmScreenAuthorization.checkBoxes.Select(x => x.Text).ToList() ?? throw new ArgumentNullException("Selecione a Autorização")
                    };

                    if (user is null)
                    {
                        throw new ArgumentException("Usuário não pode ser nulo");
                    }
                    else
                    {
                        user.Password = PasswordGenerator.Generator(user.Password);

                        if (_update)
                        {
                            user.Id = Guid.Parse(txtId.Text);
                            UserService.Put(user);
                            await Task.Delay(800);
                            UpdateData();
                            tabUser.SelectedTab = tpConsult;
                        }
                        else
                        {
                            UserService.Post(user);
                            await Task.Delay(800);
                            UpdateData();
                            tabUser.SelectedTab = tpConsult;
                        }
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

        #region Exit_Click
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnAuthorization_Click
        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            frmScreenAuthorization sa = new frmScreenAuthorization();
            sa.ShowDialog();
        }
        #endregion

        #region txtSearch_KeyPress
        private async void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            await Task.Delay(800);
            
            if(dgUser.Rows.Count > 0)
            {
                dgUser.DataSource = await UserService.Get();
            }
            else
            {
                dgUser.DataSource = await UserService.Get(txtSearch.Text);
            }
        }
        #endregion

        #region dgUser_KeyDown
        private void dgUser_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up && e.KeyCode == Keys.Down)
                {
                    dgUser = Helpers.UpOrDown(e, dgUser);
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    UpdateDetails();
                    btnUpdate_Click(sender, e);
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
            Helpers.ClearScreen(this);
            UpdateData();
            tabUser.SelectedTab = tpConsult;
        }
        #endregion
    }
}