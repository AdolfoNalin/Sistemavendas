using SistemaVenda.br.pro.com.dao;
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

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        frmConsultarCliente cc = new frmConsultarCliente();
        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Helpers helpers = new Helpers();
            helpers.LimparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = int.Parse(txtCodigo.Text);
            cliente.Nome = txtNome.Text;
            cliente.Apelido = txtApelido.Text;
            cliente.RG = mtbRG.Text;
            cliente.CPF = mtbCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.CEP = mtbCEP.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Complemento = txtComplemento.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbUF.Text;

            //cliente.Imagem = Convert.ToByte(pbImagem);

            // 2 passo - Criar um objeto da classe ClienteDAO para auterar os dados do cliente
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.EditarCliente(cliente);

            // Atualizar o dataGrid view
            cc.dgCliente.DataSource = clienteDao.ConsultarClientes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            // Passando o valor do Codigo para o codigo do cliente
            obj.Codigo = int.Parse(txtCodigo.Text);

            // Realizando a Exclusãos do cliente
            ClienteDAO objDao = new ClienteDAO();
            objDao.ExcluirClientes(obj);

            // Atualizar após a deleção
            cc.dgCliente.DataSource = objDao.ConsultarClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Apelido = txtApelido.Text;
            cliente.RG = mtbRG.Text;
            cliente.CPF = mtbCPF.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.CEP = mtbCEP.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Complemento = txtComplemento.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Estado = cbUF.Text;
            //cliente.Imagem = Convert.ToByte(pbImagem);

            // 2 passo - Criar um objeto da classe ClienteDAO
            ClienteDAO clienteDao = new ClienteDAO();
            clienteDao.CadastrarCliente(cliente);

            

            DialogResult result = MessageBox.Show("Deseja cadastrar outro Cliente? ", "Cadastrar outro clinte?" ,MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                txtNome.Text = String.Empty;
                txtApelido.Text = String.Empty;
                mtbRG.Text = String.Empty;
                mtbCPF.Text = String.Empty;
                txtEmail.Text = String.Empty;
                mtbTelefone.Text = String.Empty;
                mtbCelular.Text = String.Empty;
                mtbCEP.Text = String.Empty;
                txtLogradouro.Text = String.Empty;
                txtNumero.Text = String.Empty;
                txtComplemento.Text = String.Empty;
                txtBairro.Text = String.Empty;
                txtCidade.Text = String.Empty;
                cbUF.Text = String.Empty;
            }
            else
            {
                this.Hide();
            }

            cc.dgCliente.DataSource = clienteDao.ConsultarClientes();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO obj = new ClienteDAO();
            cc.dgCliente.DataSource = obj.ConsultarClientes();
        }

        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string cep = mtbCEP.Text;
                    string xmlUrl = "https://viacep.com.br/ws/" + cep + "/xml";
                    DataSet dado = new DataSet();
                    dado.ReadXml(xmlUrl);

                    txtLogradouro.Text = dado.Tables[0].Rows[0]["logradouro"].ToString();
                    txtBairro.Text = dado.Tables[0].Rows[0]["bairro"].ToString();
                    txtCidade.Text = dado.Tables[0].Rows[0]["localidade"].ToString();
                    txtComplemento.Text = dado.Tables[0].Rows[0]["complemento"].ToString();
                    cbUF.Text = dado.Tables[0].Rows[0]["uf"].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Endereço não encontrado. Por favor digite manualmente!");
                }
            }
        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
