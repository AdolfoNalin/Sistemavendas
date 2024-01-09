using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.veiw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.view
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        #region Load
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region ConsultarFuncionar
        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedor ConsultarForn = new frmConsultarFornecedor();
            ConsultarForn.dgFornecedor.DataSource = new FornecedorDAO().ConsultarFornecedores();
            ConsultarForn.ShowDialog();
        }
        #endregion

        #region CadastrarFuncionario
        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor cadastrarForn = new frmCadastrarFornecedor();
            cadastrarForn.ShowDialog();
        }
        #endregion

        #region ConsultarProduto
        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultarProduto consultarProd = new frmConsultarProduto();
            consultarProd.dgProduto.DataSource = new ProdutoDAO().ConsultarProdutos();
            consultarProd.Show();
        }
        #endregion

        #region CadastrarProduto 
        private void cadatrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto cadastrarProd = new frmCadastrarProduto();
            cadastrarProd.ShowDialog();
        }
        #endregion

        #region ConsultarFuncionario
        private void consultarFuncionario_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario consultarFun = new frmConsultarFuncionario();
            consultarFun.dgFuncionario.DataSource = new FuncionarioDAO().ConsultarFuncionario();
            consultarFun.ShowDialog();
        }
        #endregion

        #region cadastraFuncionario
        private void cadastrarFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario cadastrarFun = new frmCadastrarFuncionario();
            cadastrarFun.ShowDialog();
        }
        #endregion

        #region HistoricoVenda
        private void históricoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoricoVenda hv = new frmHistoricoVenda();
            hv.ShowDialog();
        }
        #endregion

        #region ConsultarCliente
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente consultarCli = new frmConsultarCliente();
            consultarCli.dgCliente.DataSource = new ClienteDAO().ConsultarClientes();
            consultarCli.ShowDialog();
        }
        #endregion

        #region CadastrarCliente
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cadastrarCli = new frmCadastrarCliente();
            cadastrarCli.ShowDialog();
        }
        #endregion

        #region Venda
        private void produrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda venda= new frmVenda();
            venda.ShowDialog();
        }
        #endregion

        #region ConsultarOrcamento
        private void btnConsultarOrcamento_Click(object sender, EventArgs e)
        {
            frmConsultarOrcamento consultarOrca = new frmConsultarOrcamento();
            consultarOrca.ShowDialog();
        }
        #endregion

        #region CadastrarOrcamento
        private void btnCadastrarOrcamento_Click(object sender, EventArgs e)
        {
            frmCadastrarOrcamento cadsatrarOrca = new frmCadastrarOrcamento();
            cadsatrarOrca.ShowDialog();
        }
        #endregion

        #region DevolucaoItem
        private void devoluçãoDeItensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucaoProduto dp = new frmDevolucaoProduto();
            dp.ShowDialog();
        }
        #endregion

        #region btnSair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult resp = MessageBox.Show("Você deseja sair do sistema?", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        #endregion

        #region btnTrocarUsuario
        private void trocaDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Hide();
        }
        #endregion
    }
}