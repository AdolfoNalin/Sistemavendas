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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmSupplier : Form
    {
        private bool _update = false;
        public frmSupplier()
        {
            InitializeComponent();
            UpdateData();
        }

        #region UpdateData
        private void UpdateData()
        {
            DataTable dt = new DataTable();
            dt = new FornecedorDAO().ConsultarFornecedores();

            dgSupplier.DataSource = dt;
        }

        #endregion

        #region UpdateDetails
        private void UpdateDetails()
        {
            Fornecedor supplier = new Fornecedor();

            if (dgSupplier.Rows.Count > 0)
            {
                supplier = (Fornecedor) dgSupplier.SelectedRows[0].DataBoundItem;

                txtCodigo.Text = supplier.Codigo.ToString();
                txtNome.Text = supplier.Nome.ToString();
                txtApelido.Text = supplier.Apelido.ToString();
                mtbRG.Text = supplier.RG.ToString();
                mtbCPF.Text = supplier.CPF.ToString();
                mtbCNPJ.Text = supplier.CNPJ.ToString();
                mtbCelular.Text = supplier.Celular.ToString();
                mtbTelefone.Text = supplier.Telefone.ToString();
                txtEmail.Text = supplier.Email.ToString();
                mtbCEP.Text += supplier.CEP.ToString();
                txtLogradouro.Text = supplier.Logradouro.ToString();
                txtNumero.Text = supplier.Numero.ToString();
                txtBairro.Text = supplier.Bairro.ToString();
                txtCidade.Text = supplier.Cidade.ToString();
                cbUF.Text = supplier.Estado.ToString();
                txtComplemento.Text = supplier.Complemento.ToString();
            }
        }
        #endregion

        #region Load
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion

        #region dgSupplier_SelectionChange
        private void dgSupplier_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }
        #endregion

        #region btnNew_Click
        private void btnNew_Click(object sender, EventArgs e)
        {
            tabSupplier.SelectedTab = tpDetails;
            Helpers.LimparTela(this);
            _update = false;
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
            _update = true;
        }
        #endregion

        #region btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            Fornecedor supplier = new Fornecedor() {
                Codigo = int.Parse(txtCodigo.Text ?? throw new ArgumentNullException("Código é nulo, verifique o cleinte")),
                Nome = txtNome.Text,
                Apelido = txtApelido.Text,
                Email = txtEmail.Text,
                CPF = mtbCEP.Text,
                CNPJ = mtbCNPJ.Text,
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

            FornecedorDAO dao = new FornecedorDAO();
            if (supplier == null)
            {
                throw new NullReferenceException("O fornecedor é nulo");
            }

            if(_update)
            {
                dao.EditarFornecedor(supplier);
            }
            else
            {
                dao.CadastrarFornecedor(supplier);
            }
        }
        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnCancel_click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
            tabSupplier.SelectedTab = tpConsult;
            UpdateData();
        }
        #endregion
        
        #region btnDelete_click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Fornecedor supplier = new Fornecedor();

            if(dgSupplier.Rows.Count > 0)
            {
                supplier = (Fornecedor)dgSupplier.SelectedRows[0].DataBoundItem;

                FornecedorDAO dao = new FornecedorDAO();
                dao.ExcluirFornecedor(supplier);
            }
        }
        #endregion
    }
}
