using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.CodeDom;
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
    public class SaleService
    {
        #region Get
        public async static Task<BindingList<Sale>> Get()
        {
            try
            {
                BindingList<Sale> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("Sale");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Sale>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
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

        #region GetOrdenOpen
        public async static Task<BindingList<Sale>> GetOrderOpen(Guid clientId)
        {
            try
            {
                BindingList<Sale> sales = new BindingList<Sale>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Sale/OrderOpen/{clientId}");

                if (response.IsSuccessStatusCode)
                {
                    sales = JsonConvert.DeserializeObject<BindingList<Sale>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return sales;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region LastSale
        public static async Task<Sale> LastSale()
        {
            Sale sale = null;
            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("Sale/Last");

                if (response.IsSuccessStatusCode)
                {
                    sale = JsonConvert.DeserializeObject<Sale>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return sale;
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }

        #endregion

        #region GetId
        public static async Task<BindingList<Sale>> Get(Guid id)
        {
            try
            {

                BindingList<Sale> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Sale/Search/{id}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Sale>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
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

        #region GetCash
        public static async Task<BindingList<Sale>> GetCash(Guid cashId)
        {
            try
            {

                BindingList<Sale> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Sale/CashSession/{cashId}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Sale>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
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
        public static async Task<BindingList<Sale>> Get(string value)
        {
            try
            {
                BindingList<Sale> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Sale/{value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<Sale>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
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
        public static async Task<BindingList<Sale>> Get(string startDate, string endDate)
        {
            try
            {
                BindingList<Sale> sales = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Sale/Date?startDate={startDate}&endDate={endDate}");

                if (response.IsSuccessStatusCode)
                {
                    sales = JsonConvert.DeserializeObject<BindingList<Sale>>(await response.Content.ReadAsStringAsync())
                        ?? throw new ArgumentNullException("Nenhuma venda encontrada nesta data");
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message, "ATENÇÃO");
                }

                return sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region Post
        public static async Task<bool> Post(Sale sale)
        {
            try
            {
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("Sale", sale);

                if (response.IsSuccessStatusCode)
                {
                    result = Boolean.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    result = false;
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
        public static async Task<bool> Put(Sale sale)
        {
            try
            {
                bool result = false;   

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("Sale", sale);

                if (response.IsSuccessStatusCode)
                {
                    result = Boolean.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
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
        public static async void Delete(Guid id)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"Sale/{id}");

                if (response.IsSuccessStatusCode)
                {
                    message += await response.Content.ReadAsStringAsync();
                }
                else
                {
                    message += await response.Content.ReadAsStringAsync();
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
