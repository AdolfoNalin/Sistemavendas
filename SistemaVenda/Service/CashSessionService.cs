using iTextSharp.text.io;
using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SistemaVenda.Service
{
    public class CashSessionService
    {
        #region Get
        public static async Task<BindingList<CashSession>> Get()
        {
            try
            {
                BindingList<CashSession> cashDescks = new BindingList<CashSession>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync("CashSession");

                if (response.IsSuccessStatusCode)
                {
                    cashDescks = JsonConvert.DeserializeObject<BindingList<CashSession>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return cashDescks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetDate
        public static async Task<BindingList<CashSession>> Get(string startDate, string endDate)
        {
            try
            {
                BindingList<CashSession> cashDescks = new BindingList<CashSession>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashSession/Date?startDate={startDate}&endDate={endDate}");

                if (response.IsSuccessStatusCode)
                {
                    cashDescks = JsonConvert.DeserializeObject<BindingList<CashSession>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return cashDescks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetId
        public static async Task<CashSession> Get(Guid id)
        {
            try
            {
                CashSession cashSession = new CashSession();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashSession/search/{id}");

                if (response.IsSuccessStatusCode)
                {
                    cashSession = JsonConvert.DeserializeObject<CashSession>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return cashSession;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetEmployee
        public static async Task<BindingList<CashSession>> GetEmployee(string value)
        {
            try
            {
                BindingList<CashSession> cashDescks = new BindingList<CashSession>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashSession/Employee/{value}");

                if (response.IsSuccessStatusCode)
                {
                    cashDescks = JsonConvert.DeserializeObject<BindingList<CashSession>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return cashDescks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetEnabel
        public static async Task<BindingList<CashSession>> GetEnable(Enable enable)
        {
            try
            {
                BindingList<CashSession> cashDescks = new BindingList<CashSession>();

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"CashSession/Enabel/{enable}");

                if (response.IsSuccessStatusCode)
                {
                    cashDescks = JsonConvert.DeserializeObject<BindingList<CashSession>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return cashDescks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region Post
        public static async void Post(CashSession cash)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("CashSession", cash);

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

        #region Put
        public static async void Put(CashSession cash)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("CashSession", cash);

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

        #region Put
        public static async Task<bool> PutCashMoviment(CashSession cash)
        {
            try
            {
                bool result = false;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("CashSession/CashMoviment", cash);

                if (response.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    string message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(message);
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

        #region Enable
        public static async void Enable(CashSession cash)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("CashSession/Disable", cash);

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