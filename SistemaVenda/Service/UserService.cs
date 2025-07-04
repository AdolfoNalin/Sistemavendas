using Microsoft.Xml.Serialization.GeneratedAssembly;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Tls;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.Model;
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
    public class UserService
    {
        #region Login
        public async Task<bool> Login(User user)
        {
			try
			{
				string message = "";
				bool result = false;
				
				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.PostAsJsonAsync("User/Login",user);

				if (response.IsSuccessStatusCode)
				{
					message = await response.Content.ReadAsStringAsync();
					result = true;
				}
				else
				{
					message = await response.Content.ReadAsStringAsync();
				}

				MessageBox.Show(message);
				return result;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
				return false;
			}
        }
        #endregion

        #region Get
		public async Task<List<User>> Get()
		{
			try
			{ 
				List<User> list = null;
				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync("User");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<User>>(await response.Content.ReadAsStringAsync());
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

        #region GetId
		public async Task<List<User>> Get(Guid id)
		{
			try
			{
				List<User> list = null;
				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync($"User/{id}");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<User>>(await response.Content?.ReadAsStringAsync());
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
        public async Task<List<User>> Get(string value)
		{
			try
			{
				List<User> list = null;
				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync($"User/{value}");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<User>>(await response.Content?.ReadAsStringAsync());
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
		public async Task<bool> Post(User user)
		{
			try
			{
				string message = "";
				bool result = false;

				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.PostAsJsonAsync("Usser", user);

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
        public async Task<bool> Put(User user)
        {
            try
            {
                string message = "";
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("Usser", user);

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
                HttpResponseMessage response = await client.DeleteAsync($"Usser/{id}");

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
    }
}
