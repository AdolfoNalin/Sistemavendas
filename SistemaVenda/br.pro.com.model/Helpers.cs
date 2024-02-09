using SistemaVenda.br.pro.com.dao;
using SistemaVenda.br.pro.com.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.model
{
    public class Helpers
    {
        frmCadastrarOrcamento tela = new frmCadastrarOrcamento();

        #region Limpar
        /// <summary>
        /// Calsse deticata a realziar a limpeza de tela, podendo ser usada com qualquer tela form
        /// </summary>
        /// <param name="tela">Tela que vai ser limpa</param>
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = String.Empty;
                            }
                            else if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = String.Empty;
                            }
                            else if (ctr2 is ComboBox)
                            {
                                (ctr2 as ComboBox).Text = String.Empty;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        public void Gravar(DataGridView dataTable, string nomeFuncionario, string nomeCliente, Orcamento orcamento)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                Cliente cliente = new Cliente();
                
                ClienteDAO clienteDao = new ClienteDAO();
                FuncionarioDAO funcionarioDao = new FuncionarioDAO();

                cliente = clienteDao.ListarNome(nomeCliente);
                funcionario = funcionarioDao.ListarNome(nomeFuncionario);

                int quantidade = int.Parse(dataTable.CurrentRow.Cells[2].Value.ToString());
                int quantidadeTotal = 0;

                quantidadeTotal += quantidade;

                orcamento.CodigoCliente = cliente.Codigo;
                orcamento.CodigoVendedor = funcionario.Codigo;

                orcamento.DescontoPorcentagem = Decimal.Parse(tela.mtbDP.Text);
                orcamento.DescontoReal = Decimal.Parse(tela.mtbDD.Text);
                orcamento.AcrescimoPorcentagem = Decimal.Parse(tela.mtbAP.Text);
                orcamento.AcrescimoReal = Decimal.Parse(tela.mtbAP.Text);
                orcamento.SubTotal = Decimal.Parse(tela.mtbSubTotal.Text);
                orcamento.Total = Decimal.Parse(tela.mtbTotal.Text);
                orcamento.Alteracoes = Decimal.Parse(tela.mtbAteracoes.Text);
                orcamento.Obs = tela.txtObs.Text;
                orcamento.Data = DateTime.Parse(tela.mtbData.Text);
                orcamento.Hora = DateTime.Parse(tela.mtbHora.Text);
                orcamento.QuantidadeTotal = quantidadeTotal;

                OrcamentoDAO dao = new OrcamentoDAO();

                foreach (DataGridViewRow linha in tela.dgOrcamento.Rows)
                {
                    ItemOrcamento item = new ItemOrcamento();
                    item.CodigoOrcamento = dao.UltimoOrcamento();
                    item.CodigoProduto = int.Parse(linha.Cells[0].Value.ToString());
                    item.Quantidade = int.Parse(linha.Cells[2].Value.ToString());
                    item.Subtotal = Decimal.Parse(linha.Cells[5].Value.ToString());

                    ItemOrcamentoDAO itemDao = new ItemOrcamentoDAO();
                    itemDao.CadastrarItemOrcamento(item);
                }

                tela.txtCodigo.Text = dao.UltimoOrcamento().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Acoteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
    }
}
