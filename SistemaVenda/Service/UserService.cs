using Microsoft.Xml.Serialization.GeneratedAssembly;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Tls;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
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
    public class UserService
    {
        #region Login
        public static async Task<UserResponse> Login(UserResquest user)
        {
			try
			{
				string message = "";
				UserResponse userResponse = null;
				
				HttpClient client = ConnectionFactory.ConnectionLocalhostUser();
				HttpResponseMessage response = await client.PostAsJsonAsync("User/Login",user);

				if (response.IsSuccessStatusCode)
				{
					userResponse = JsonConvert.DeserializeObject<UserResponse>(await response.Content.ReadAsStringAsync());
				}
				else
				{
					message = await response.Content.ReadAsStringAsync();
					MessageBox.Show(message);
				}

				return userResponse;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
				return null;
			}
        }
        #endregion

        #region Get
		public static async Task<List<User>> Get()
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
		public static async Task<BindingList<User>> Get(Guid id)
		{
			try
			{
				BindingList<User> list = null;
				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync($"User/{id}");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<BindingList<User>>(await response.Content?.ReadAsStringAsync());
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

        #region GetEmployeeId
        public static async Task<User> GetEmployee(Guid employeeId)
        {
            try
            {
                User user = null;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"User/Employee/{employeeId}");

                if (response.IsSuccessStatusCode)
                {
                    user = JsonConvert.DeserializeObject<User>(await response.Content?.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }
                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region GetSmart
        public static async Task<List<User>> Get(string value)
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

        #region GetPassword
		public static async Task<UserResponse> GetPassword(string password)
		{
			try
			{
				UserResponse user = new UserResponse();

				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync($"User/Password?password={password}");

				if(response.IsSuccessStatusCode)
				{
					user = JsonConvert.DeserializeObject<UserResponse>(await response.Content.ReadAsStringAsync());
				}
				else
				{
					MessageBox.Show(await response.Content.ReadAsStringAsync());
				}

				return user;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
				return null;
			}
		}
        #endregion

        #region Post
        public static async void Post(User user)
		{
			try
			{
				string message = "";

				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.PostAsJsonAsync("User", user);

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
        public static async void Put(User user)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("User", user);

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

        #region Delete
        public static async void Delete(Guid id)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"User/{id}");

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
