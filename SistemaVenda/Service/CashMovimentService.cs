using iTextSharp.text.io;
using iTextSharp.text.pdf.security;
using Newtonsoft.Json;
using Org.BouncyCastle.Ocsp;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Service
{
    public class CashMovimentService
    {
        #region Get
        public async Task<BindingList<CashMoviment>> Get()
        {
            try
            {
                BindingList<CashMoviment> list = new BindingList<CashMoviment>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("CashMoviment");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<CashMoviment>>(await response.Content.ReadAsStringAsync());
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
        public async Task<BindingList<CashMoviment>> Get(DateTime startDate, DateTime endDate)
        {
            try
            {
                BindingList<CashMoviment> list = new BindingList<CashMoviment>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashMoviment?startDate={startDate}&endDate={endDate}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<CashMoviment>>(await response.Content.ReadAsStringAsync());
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
        public async Task<BindingList<CashMoviment>> Get(string user)
        {
            try
            {
                BindingList<CashMoviment> list = new BindingList<CashMoviment>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashMoviment/User/{user}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<CashMoviment>>(await response.Content.ReadAsStringAsync());
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
        public async void Post(CashMoviment moviment)
        {
            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("CashMoviment", moviment);

                MessageBox.Show(await response.Content.ReadAsStringAsync());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Put
        public async void Put(CashMoviment moviment)
        {
            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("CashMoviment", moviment);

                MessageBox.Show(await response.Content.ReadAsStringAsync());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
            }
        }
        #endregion

        #region Delete
        public async void Delete(Guid id)
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
