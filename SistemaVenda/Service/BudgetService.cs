using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Service
{
    public class BudgetService
    {
        #region Get
        public static async Task<List<Budget>> Get()
        {
            try
            {
                List<Budget> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("Budget");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Budget>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}. {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetId
        public static async Task<List<Budget>> Get(Guid id)
        {
            try
            {
                List<Budget> list = null;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Budget/{id}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Budget>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetSmart
        public static async Task<List<Budget>> Get(string value)
        {
            try
            {
                List<Budget> list = null;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Budget/{value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Budget>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region Post
        public static async Task<bool> Post(Budget budget)
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("Budget", budget);

                if (response.IsSuccessStatusCode) 
                {
                    message = await response.Content.ReadAsStringAsync();
                    result = true; 
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return false;
            }
        }
        #endregion

        #region Put
        public static async Task<bool> Put(Budget budget)
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("Budget", budget);

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                    result = true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return false;
            }
        }
        #endregion

        #region Delete
        public static async Task<bool> Delete(Guid id)
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"Budget/{id}");

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                    result = true;
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return false;
            }
        }
        #endregion

        #region EndBudget
        public static async Task<Guid> GetLastBudget()
        {
            try
            {
                List<Budget> budgets = await BudgetService.Get();
                Budget budget = budgets.LastOrDefault() ?? throw new ArgumentException("Não existe orçamento no banco de dados");

                return budget.Id;
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
                return Guid.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return Guid.Empty;
            }
        }
        #endregion
    }
}
