using SistemaVenda.br.pro.com.dao;
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
    public partial class frmHistoricoDevolucao : Form
    {
        public frmHistoricoDevolucao()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultarDevolucaoProduto_Load(object sender, EventArgs e)
        {
            dtpDataInicio.Visible = true;
            dtpDataFim.Visible = true;

            dgConsutarOrcamento.Columns.Clear();

            dgConsutarOrcamento.Columns.Add("codigo", "Código");
            dgConsutarOrcamento.Columns.Add("venda", "Venda");
            dgConsutarOrcamento.Columns.Add("cliente", "cliente");
            dgConsutarOrcamento.Columns.Add("quantidade", "Quantidade");
            dgConsutarOrcamento.Columns.Add("motivo", "Motivo");
            dgConsutarOrcamento.Columns.Add("total", "Total");
            dgConsutarOrcamento.Columns.Add("observacao", "Observação");

            DevolucaoDAO dao = new DevolucaoDAO();
            dgConsutarOrcamento.DataSource = dao.ConsultarDevolucao();
        }
        #endregion
    }
}
