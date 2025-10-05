using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Service
{
    public class ReturnService
    {
        #region Get
        public static async Task<BindingList<Return>> Get()
        {
            try
            {
                BindingList<Return> list = new BindingList<Return>();
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("Return");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Return>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Atenção");
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

        #region GetDate
        public static async Task<BindingList<Return>> Get(DateTime startDate, DateTime endDate)
        {
            try
            {
                BindingList<Return> list = new BindingList<Return>();
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Return/Date?startDate={startDate}&endDate={endDate}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Return>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Atenção");
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

        #region Get
        public static async Task<BindingList<Return>> Get(string value)
        {
            try
            {
                BindingList<Return> list = new BindingList<Return>();
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Return/smart/{value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Return>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Atenção");
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
        public static async Task<bool> Post(Return @return)
        {
            try
            {
                bool result = false;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("Return", @return);

                if (response.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Atenção");
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
        public static async Task<bool> Put(Return @return)
        {
            try
            {
                bool result = false;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("Return", @return);

                if (response.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Atenção");
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
        public static async void Delete(Guid returnId)
        {
            try
            {
                string message = "";
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"Return/{returnId}");

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}
