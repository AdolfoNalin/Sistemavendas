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
using System.ComponentModel;
using SistemaVenda.Model.Helpers;
using System.Fabric.Management.ServiceModel;
using MySqlX.XDevAPI.Common;

namespace SistemaVenda.br.pro.com.model.Helpers
{
    public class Helpers
    {
        #region Limpar
        /// <summary>
        /// Calsse deticata a realziar a limpeza de tela, podendo ser usada com qualquer tela form
        /// </summary>
        /// <param name="tela">Tela que vai ser limpa</param>
        public static void ClearScreen(Form tela)
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
        public async void Gravar(DataGridView dataGirdView, string nameEmp, Guid clientId, Budget budget)
        {
            try
            {
                frmBudget screen = new frmBudget();
                
                Client client = await ClientService.Get(clientId) ?? throw new ArgumentNullException("Nome do Cliente não é válido");

                List<Employee> employees = await EmployeeService.Get(nameEmp);

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

                screen.txtClientId.Text = BudgetService.GetLastBudget().ToString();
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

        #region Address
        public static string Address(Client client)
        {
            string result = $"{client.State}, {client.City}, {client.Neighborhoods}, {client.Street}, {client.Number}, {client.Complement}"; 
            return result ;
        }
        #endregion

        #region UpOrDown
        public static DataGridView UpOrDown(KeyEventArgs e, DataGridView dg)
        {
            try
            {
                int index = 0;
                if (e.KeyCode == Keys.Up)
                {
                    if (index > 0 && dg.Rows.Count <= index)
                    {
                        index = dg.CurrentCell.RowIndex;
                        dg.CurrentCell = dg.Rows[index - 1].Cells[0];
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (index > 0 && dg.Rows.Count <= index)
                    {
                        index = dg.CurrentCell.RowIndex;
                        dg.CurrentCell = dg.Rows[index - 1].Cells[0];
                    }
                }
                
                return dg;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region Switch
        public static async Task<BindingList<CashSession>> SwitchEnabel(BindingList<CashSession> cashSessions)
        {
            try
            {
                cashSessions.ToList().ForEach(c =>
                {
                    c.Enable = c.Enable == Enable.Enable ? Enable.Habilitado : Enable.Desabilitado;

                    c.Status = c.Status == IsCashSession.Open ? IsCashSession.Aberto : IsCashSession.Fechado;
                });

                foreach (var c in cashSessions)
                {
                    c.User = await UserService.Get(c.UserId);
                }

                return cashSessions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region CalculateChange
        public static decimal CalculateChange(decimal entryValue, decimal total)
        {
            decimal result = 0;
            try
            {
                decimal entryPrice = ParseVerification.ParseDecimal(entryValue.ToString(), "Somente números são aceitos");
                decimal totalPrice = ParseVerification.ParseDecimal(total.ToString(), "Somente números são aceitos");

                result = totalPrice - entryPrice;

                if(totalPrice > entryValue)
                {
                    throw new ArgumentException($"Está faltando R${result}");
                }

                return result;
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.ParamName);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.StackTrace}, {ex.HelpLink}");
                return -404;
            }
        }
        #endregion
    }
}
