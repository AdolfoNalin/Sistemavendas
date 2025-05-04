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
    public partial class frmClient : Form
    {
        private bool _update = false;

        public frmClient()
        {
            InitializeComponent();
        }

        #region UpdateData
        private void UpdateData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = new ClienteDAO().ConsultarClientes();
                _ = dt == null ? throw new NullReferenceException("Lista está vazia!") : dgClient.DataSource = dt;
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region UpdateDetails
        private void UpdateDetails()
        {
            Cliente cliente = new Cliente();
            if (dgClient.Rows.Count > 0)
            {
                cliente = (Cliente)dgClient.SelectedRows[0].DataBoundItem;

                txtCodigo.Text = cliente.Codigo.ToString();
                txtNome.Text = cliente.Nome.ToString();
                txtApelido.Text = cliente.Apelido.ToString();
                mtbRG.Text = cliente.RG.ToString();
                mtbCPF.Text = cliente.CPF.ToString();
                mtbCelular.Text = cliente.Celular.ToString();
                mtbTelefone.Text = cliente.Telefone.ToString();
                txtEmail.Text = cliente.Email.ToString();
                mtbCEP.Text += cliente.CEP.ToString();
                txtLogradouro.Text = cliente.Logradouro.ToString();
                txtNumero.Text = cliente.Numero.ToString();
                txtBairro.Text = cliente.Bairro.ToString();
                txtCidade.Text = cliente.Cidade.ToString();
                cbUF.Text = cliente.Estado.ToString();
                txtComplemento.Text = cliente.Complemento.ToString();
            }
        }
        #endregion

        #region Load
        private void frmClient_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        #endregion

        #region mtbCEP_KeyDown
        private void mtbCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                City city = SearchCEP.SearchCity(mtbCEP.Text);

                if (city != null)
                {
                    txtCidade.Text = city.Name;
                    txtLogradouro.Text = city.Street;
                    txtBairro.Text = city.Neighborhood;
                    cbUF.Text = city.UF;
                    txtComplemento.Text = city.Complement;
                    mtbCEP.Text = city.CEP;
                }
            }
        }
        #endregion

        #region txtSearch_KeyPress
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            
            dgClient.DataSource = dao.ListarClienteNome(txtSearch.Text);
        }
        #endregion

        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            dgClient.DataSource = new ClienteDAO().BuscarClienteNome(value);
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
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtApelido.Text = String.Empty;
            txtEmail.Text = String.Empty;
            mtbRG.Text = String.Empty;
            mtbCPF.Text = String.Empty;
            mtbTelefone.Text = String.Empty;
            mtbCelular.Text = String.Empty;
            mtbCEP.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty; 
            txtComplemento.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            cbUF.Text = String.Empty;

            tabClient.SelectedTab = tpDetails;
        }
        #endregion

        #region btnUpdate_Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _update = true;
            UpdateDetails();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente obj = new Cliente()
                {
                    Codigo = int.Parse(txtCodigo.Text ?? throw new ArgumentNullException("Código é nulo, verifique o cleinte")),
                    Nome = txtNome.Text,
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

                if (obj == null )
                {
                    throw new NullReferenceException("Cliente é nulo, impossivel deletar!");
                }

                ClienteDAO objDao = new ClienteDAO();
                objDao.ExcluirClientes(obj);
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch(NullReferenceException ne)
            {
                MessageBox.Show(ne.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        #endregion

        #region btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente obj = new Cliente()
                {
                    Codigo = int.Parse(txtCodigo.Text ?? throw new ArgumentNullException("Código é nulo, verifique o cleinte")),
                    Nome = txtNome.Text,
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

                if (obj == null)
                {
                    throw new NullReferenceException("Clinte está nulo, impossivel salvar");
                }

                ClienteDAO objDao = new ClienteDAO();
                if(_update)
                {
                    objDao.EditarCliente(obj);
                }
                else
                {
                    objDao.CadastrarCliente(obj);
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

        #region dgClient_SelectionChanged
        private void dgClient_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }
        #endregion
    }
}
