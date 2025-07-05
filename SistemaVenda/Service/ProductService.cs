using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Service
{
    public class ProductService
    {
        #region Get
        public async Task<List<Product>> Get()
        {
            try
            {
                List<Product> products = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("Product");

                if (response.IsSuccessStatusCode)
                {
                    products = JsonConvert.DeserializeObject<List<Product>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetId
        public async Task<List<Product>> Get(Guid id)
        {
            try
            {
                List<Product> products = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    products = JsonConvert.DeserializeObject<List<Product>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetSmart
        public async Task<List<Product>> Get(string value)
        {
            List<Product> products = null;

            HttpClient client = ConnectionFactory.ConnectionLocalhost();
            HttpResponseMessage response = await client.GetAsync($"Product/{value}");

            if (response.IsSuccessStatusCode)
            {
                products = JsonConvert.DeserializeObject<List<Product>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                MessageBox.Show(await response.Content.ReadAsStringAsync());
            }

            return products;
        }
        #endregion

        #region Post
        public async Task<bool> Post(Product product)
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("Product", product);

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
        public async Task<bool> Put(Product product)
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("Product", product);

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
        public async Task<bool> Delete(Guid id) 
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"Product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    message += await response.Content.ReadAsStringAsync();
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
    }
}
