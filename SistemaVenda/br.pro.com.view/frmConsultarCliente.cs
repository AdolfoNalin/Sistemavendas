using K4os.Compression.LZ4.Streams.Internal;
using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.br.pro.com.veiw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmConsultarCliente : Form
    {
        public bool TelaVendaAberta { get; set; }
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        public frmConsultarCliente(bool isdisposed)
        {
            InitializeComponent();
            this.TelaVendaAberta = isdisposed;
        }

        #region Load
        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO objDao = new ClienteDAO();
            dgCliente.DataSource = objDao.ConsultarClientes();
        }
        #endregion

        #region btnPesquisarClick
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgCliente.DataSource = dao.ListarNome(txtNome.Text);
        }
        #endregion

        #region txtNome listarClienteNome
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = '%' + txtNome.Text + '%';

            ClienteDAO clienteDao = new ClienteDAO();
            dgCliente.DataSource = clienteDao.ListarClienteNome(nome);

            if (dgCliente.Rows.Count == 0 || txtNome.Text == String.Empty)
            {
                dgCliente.DataSource = clienteDao.ConsultarClientes();
            }
        }

        #endregion

        private void dgCliente_Click(object sender, EventArgs e)
        {   
            this.Hide();

            frmCadastrarCliente cc = new frmCadastrarCliente();

            ClienteDAO objDao = new ClienteDAO();
            // 1 passo - Pegar os dados da linha selecionada
            cc.txtCodigo.Text = dgCliente.CurrentRow.Cells[0].Value.ToString();
            cc.txtNome.Text = dgCliente.CurrentRow.Cells[1].Value.ToString();
            cc.txtApelido.Text = dgCliente.CurrentRow.Cells[2].Value.ToString();
            cc.mtbRG.Text = dgCliente.CurrentRow.Cells[3].Value.ToString();
            cc.mtbCPF.Text = dgCliente.CurrentRow.Cells[4].Value.ToString();
            cc.txtEmail.Text = dgCliente.CurrentRow.Cells[5].Value.ToString();
            cc.mtbTelefone.Text = dgCliente.CurrentRow.Cells[6].Value.ToString();
            cc.mtbCelular.Text = dgCliente.CurrentRow.Cells[7].Value.ToString();
            cc.mtbCEP.Text = dgCliente.CurrentRow.Cells[8].Value.ToString();
            cc.txtLogradouro.Text = dgCliente.CurrentRow.Cells[9].Value.ToString();
            cc.txtNumero.Text = dgCliente.CurrentRow.Cells[10].Value.ToString();
            cc.txtComplemento.Text = dgCliente.CurrentRow.Cells[11].Value.ToString();
            cc.txtBairro.Text = dgCliente.CurrentRow.Cells[12].Value.ToString();
            cc.txtCidade.Text = dgCliente.CurrentRow.Cells[13].Value.ToString();
            cc.cbUF.Text = dgCliente.CurrentRow.Cells[14].Value.ToString();

            cc.ShowDialog();

            // Atualizando o DatagridView
            dgCliente.DataSource = objDao.ConsultarClientes();
        }
    }
}
