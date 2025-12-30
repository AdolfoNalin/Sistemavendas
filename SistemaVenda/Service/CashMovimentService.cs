using iTextSharp.text.io;
using iTextSharp.text.pdf.security;
using Newtonsoft.Json;
using Org.BouncyCastle.Ocsp;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Fabric;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SistemaVenda.Service
{
    public class CashMovimentService
    {
        #region Get
        public static async Task<BindingList<CashMovement>> Get()
        {
            try
            {
                BindingList<CashMovement> list = new BindingList<CashMovement>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("CashMoviment");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<CashMovement>>(await response.Content.ReadAsStringAsync());
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

        #region GetDate
        public static async Task<BindingList<CashMovement>> Get(DateTime startDate, DateTime endDate)
        {
            try
            {
                BindingList<CashMovement> list = new BindingList<CashMovement>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashMoviment?startDate={startDate}&endDate={endDate}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<CashMovement>>(await response.Content.ReadAsStringAsync());
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

        #region Get
        public static async Task<BindingList<CashMovement>> Get(string user)
        {
            try
            {
                BindingList<CashMovement> list = new BindingList<CashMovement>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashMoviment/User/{user}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<CashMovement>>(await response.Content.ReadAsStringAsync());
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
        public static async Task<bool> Post(CashMovement moviment)
        {
            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("CashMoviment", moviment);

                bool result = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
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
        public static async Task<bool> Put(CashMovement moviment)
        {
            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("CashMoviment", moviment);

                bool result = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
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
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"CashMoviment/{id}");

                MessageBox.Show(await response.Content.ReadAsStringAsync());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion
    }
}
