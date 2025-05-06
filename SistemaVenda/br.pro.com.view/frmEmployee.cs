using MySqlX.XDevAPI;
using SistemaVenda.br.pro.com.dao;
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

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmEmployee : Form
    {
        private bool _update = false;
        public frmEmployee()
        {
            InitializeComponent();
        }

        #region UpdateData
        private void UpdateData()
        {
            dgEmployee.DataSource = new FuncionarioDAO().ConsultarFuncionario();
            tabEmployee.SelectedTab = tpConsult;
        }
        #endregion

        #region UpdateDetalis
        private void UpdateDetails()
        {
            if(dgEmployee.Rows.Count > 0)
            {
                Funcionario employee = new Funcionario();

                employee = (Funcionario)dgEmployee.SelectedRows[0].DataBoundItem;

                txtCodigo.Text = employee.Codigo.ToString();
                txtNome.Text = employee.Nome.ToString();
                txtApelido.Text = employee.Apelido.ToString();
                txtPassword.Text = employee.Senha.ToString();
                cbCargo.Text = employee.Cargo.ToString();
                mtbRG.Text = employee.RG.ToString();
                mtbCPF.Text = employee.CPF.ToString();
                mtbCelular.Text = employee.Celular.ToString();
                mtbTelefone.Text = employee.Telefone.ToString();
                txtEmail.Text = employee.Email.ToString();
                mtbCEP.Text += employee.CEP.ToString();
                txtLogradouro.Text = employee.Logradouro.ToString();
                txtNumero.Text = employee.Numero.ToString();
                txtBairro.Text = employee.Bairro.ToString();
                txtCidade.Text = employee.Cidade.ToString();
                cbUF.Text = employee.Estado.ToString();
                txtComplemento.Text = employee.Complemento.ToString();

                tabEmployee.SelectedTab = tpDetails;
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
            Helpers.LimparTela(this);
            _update = false;
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
            _update = true;
            tabEmployee.SelectedTab = tpDetails;
        }
        #endregion

        #region btnSave_click
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario employee = new Funcionario()
                {
                    Codigo = int.Parse(txtCodigo.Text ?? throw new ArgumentNullException("Código é nulo, verifique o Funcionário")),
                    Nome = txtNome.Text,
                    Senha = txtPassword.Text,
                    Cargo = cbCargo.Text,
                    Apelido = txtApelido.Text,
                    Email = txtEmail.Text,
                    CPF = mtbCEP.Text,
                    RG = mtbRG.Text,
                    Telefone = mtbTelefone.Text,
                    Celular = mtbCelular.Text,
                    CEP = mtbCEP.Text,
                    Logradouro = txtLogradouro.Text,
                    Numero = int.Parse(txtNumero.Text),
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Estado = cbUF.Text,
                };

                if (employee is null)
                {
                    throw new ArgumentException("Funcionário é nulo");
                }

                FuncionarioDAO dao = new FuncionarioDAO();

                if (_update)
                {
                    dao.EditarFuncionario(employee);
                }
                else
                {
                    dao.CadastrarFuncionario(employee);
                }

                UpdateData();
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
                throw;
            }
        }
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            dgEmployee.DataSource = dao.BuscarFuncionarioNome(txtSearch.Text);
        }
        #endregion

        #region txtSearch_KeyDown
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                btnSearch_Click(sender, e);
            }
            else
            {
                FuncionarioDAO dao = new FuncionarioDAO();
                dgEmployee.DataSource = dao.ListarFuncionariosNome(txtSearch.Text);
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
    }
}
