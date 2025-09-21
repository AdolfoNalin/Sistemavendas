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
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region btnNext
        /// <summary>
        /// Evento que executa a função logar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                //string hashPassword = PasswordGenerator.Generator(txtPassword.Text);

                UserResquest user = new UserResquest()
                {
                    Login = txtName.Text,
                    Password = txtPassword.Text,
                };

                UserResponse userResponse = new UserResponse();
                userResponse = await UserService.Login(user);

                if (userResponse != null)
                {
                    UserSession.Id = userResponse.User.Id;
                    UserSession.Name = userResponse.User.Name;
                    UserSession.Login = userResponse.User.Login;
                    UserSession.EmployeeId = userResponse.User.EmployeeId;
                    UserSession.Token = userResponse.Token;
                    this.Hide();

                    new frmMenu().ShowDialog();
                }
                else
                {
                    txtName.Text = String.Empty;
                    txtPassword.Text = String.Empty;

                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}", "Atenção");
            }   
        }
        #endregion

        #region btnCancel
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region btnHelp
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        #endregion

        #region frmLogin_KeyDown
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAvancar_Click(sender, e);
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
