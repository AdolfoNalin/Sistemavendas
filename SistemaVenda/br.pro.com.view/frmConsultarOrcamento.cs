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
    public partial class frmConsultarOrcamento : Form
    {
        public frmConsultarOrcamento()
        {
            InitializeComponent();
        }

        frmCadastrarOrcamento tela = new frmCadastrarOrcamento();
        int id = 0;
       
        #region Load
        private void frmDetalhesOrcamento_Load(object sender, EventArgs e)
        {
            OrcamentoDAO dao = new OrcamentoDAO();
            dgHistoricoOrcamento.DataSource = dao.ConsultarOrcamento();
        }
        #endregion

        #region dgHistoricoOrcamento_CellClick
        private void dgHistoricoOrcamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgHistoricoOrcamento.Rows.Count == 5)
            {

            }
            else
            {
                id = int.Parse(dgHistoricoOrcamento.CurrentRow.Cells[0].Value.ToString());
                DateTime data = Convert.ToDateTime(dgHistoricoOrcamento.CurrentRow.Cells[10].Value.ToString());
                DateTime hora = Convert.ToDateTime(dgHistoricoOrcamento.CurrentRow.Cells[11].Value.ToString());

                tela.txtCodigo.Text = id.ToString();
                tela.cbCliente.Text = dgHistoricoOrcamento.CurrentRow.Cells[1].Value.ToString();
                tela.cbVendedor.Text = dgHistoricoOrcamento.CurrentRow.Cells[2].Value.ToString();
                tela.mtbDP.Text = dgHistoricoOrcamento.CurrentRow.Cells[3].Value.ToString();
                tela.mtbDD.Text = dgHistoricoOrcamento.CurrentRow.Cells[4].Value.ToString();
                tela.mtbAP.Text = dgHistoricoOrcamento.CurrentRow.Cells[5].Value.ToString();
                tela.mtbAD.Text = dgHistoricoOrcamento.CurrentRow.Cells[6].Value.ToString();
                tela.mtbSubTotal.Text = dgHistoricoOrcamento.CurrentRow.Cells[7].Value.ToString();
                tela.mtbTotal.Text = dgHistoricoOrcamento.CurrentRow.Cells[8].Value.ToString();
                tela.mtbAteracoes.Text = dgHistoricoOrcamento.CurrentRow.Cells[9].Value.ToString();
                tela.mtbData.Text = data.ToString();
                tela.mtbHora.Text = hora.ToString();
                tela.txtObs.Text = dgHistoricoOrcamento.CurrentRow.Cells[13].Value.ToString();

                ItemOrcamentoDAO orcamentoDAO = new ItemOrcamentoDAO();
                tela.dgOrcamento.Columns.Clear();
                tela.dgOrcamento.DataSource = orcamentoDAO.ListarItemOrcamento(id);
                this.Hide();
                tela.ShowDialog();
            }
        }
        #endregion

        #region
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;

            dataInicio = Convert.ToDateTime(dtpInicio.Value.ToString("yyyy-M-d"));
            dataFim = Convert.ToDateTime(dtpFim.Value.ToString("yyyy-M-d"));

            OrcamentoDAO objDao = new OrcamentoDAO();
            dgHistoricoOrcamento.DataSource = objDao.ListarHistoricoOrcamento(dataInicio, dataFim);
        }
        #endregion
    }
}
