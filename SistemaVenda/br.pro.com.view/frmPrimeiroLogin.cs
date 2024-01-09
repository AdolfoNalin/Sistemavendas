using MySql.Data.MySqlClient;
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
    public partial class frmPrimeiroLogin : Form
    {
        public frmPrimeiroLogin()
        {
            InitializeComponent();
        }

        #region btnCancelar
        /// <summary>
        /// Fecha a caixa de diálogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region CadastrarFuncionario
        /// <summary>
        /// Cria um novo funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtSenha.Text)
            {
                FuncionarioDAO objDao = new FuncionarioDAO();
                Funcionario obj = new Funcionario();

                obj.Nome = txtNome.Text;
                obj.Apelido = txtNome.Text; 
                obj.Senha = txtSenha.Text;

                objDao.CadastrarFuncionario(obj);
            }
        }
        #endregion
    }
}
