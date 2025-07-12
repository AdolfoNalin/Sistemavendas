using SistemaVenda.Service;
using SistemaVenda.br.pro.com.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVenda.Model;

namespace SistemaVenda.br.pro.com.model.Helpers
{
    public class Helpers
    {
        

        #region Limpar
        /// <summary>
        /// Calsse deticata a realziar a limpeza de tela, podendo ser usada com qualquer tela form
        /// </summary>
        /// <param name="tela">Tela que vai ser limpa</param>
        public static void LimparTela(Form tela)
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

        #region Gravar
        public async void Gravar(DataGridView dataGirdView, string nameEmp, string nameClient, Budget budget)
        {
            try
            {
                frmBudget screen = new frmBudget();
                List<Employee> listEmp = null;
                List<Client> listClient = null;
               
                listClient = await ClientService.Get(nameClient);
                Client client = listClient.FirstOrDefault() ?? throw new ArgumentNullException("Nome do Cliente não é válido");

                listEmp = await EmployeeService.Get(nameEmp);
                Employee emp = listEmp.FirstOrDefault() ?? throw new ArgumentNullException("Nome do Funcionário não é válido");

                int amount = int.Parse(dataGirdView.CurrentRow.Cells[2].Value.ToString());
                int amountTotal = 0;

                amountTotal += amount;

                bool isSucesso = await BudgetService.Post(budget);

                if (isSucesso)
                {
                    foreach (DataGridViewRow linha in dataGirdView.Rows)
                    {
                        
                        ItemBudget item = new ItemBudget();
                        item.BudgetId = await BudgetService.GetLastBudget();
                        item.ProductId = Guid.Parse(linha.Cells[0].Value.ToString());
                        item.Amount = int.Parse(linha.Cells[2].Value.ToString());
                        item.Subtotal = Decimal.Parse(linha.Cells[5].Value.ToString());

                        ItemBudgetService.Post(item);
                    }
                }

                screen.txtCodigo.Text = BudgetService.GetLastBudget().ToString();
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Acoteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion
    }
}
