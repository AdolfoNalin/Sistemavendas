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
    }
}
