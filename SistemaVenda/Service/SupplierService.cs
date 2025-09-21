using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.Model;
using System;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;

namespace SistemaVenda.Service
{
    public class SupplierService
    {
        #region Get
        public static async Task<List<Supplier>> Get()
        {
            List<Supplier> list = null;

            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();

                HttpResponseMessage response = await client.GetAsync("Supplier");

                if(response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Supplier>>(await response.Content.ReadAsStringAsync())
                        ?? throw new ArgumentNullException("Nenhum resultado encontrado");
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return list;
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
        public static async Task<List<Supplier>> Get(Guid id) 
        {
            try
            {
                List<Supplier> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Supplier/Search/{id}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Supplier>>(await response.Content.ReadAsStringAsync())
                        ?? throw new ArgumentNullException("Nenhum resultado encontrado");
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return list;
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion

        #region GetSmart
        public static async Task<List<Supplier>> Get(string value)
        {
            try
            {
                List<Supplier> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"Supplier/Smart/{value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<Supplier>>(await response.Content.ReadAsStringAsync())
                        ?? throw new ArgumentNullException("Nenhum Fornecedor encontrado");
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
                }

                return list;
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

        #region Post
        public static async void Post(Supplier supplier)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("Supplier", supplier);

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
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Put
        public static async void Put(Supplier supplier)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("Supplier", supplier);

                if (response.IsSuccessStatusCode)
                {
                    message = await response.Content.ReadAsStringAsync();;
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

        #region Delete
        public static async void Delete(Guid id) 
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"Supplier/{id}");

                if(response.IsSuccessStatusCode)
                {
                    message += await response.Content.ReadAsStringAsync();
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
