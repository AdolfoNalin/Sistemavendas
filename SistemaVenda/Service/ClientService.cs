using Newtonsoft.Json;
using SistemaVenda.Model;
using SistemaVenda.br.pro.com.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using SistemaVenda.br.pro.com.connection;


namespace SistemaVenda.Service
{
	public class ClientService
	{
		#region GetAll
		/// <summary>
		/// Lista todos os clients
		/// </summary>
		/// <returns></returns>
		public static async Task<List<Client>> Get()
		{
			List<Client> list = null;
			try
			{
				HttpClient client = ConnectionFactory.ConnectionLocalhost();

				HttpResponseMessage response = await client.GetAsync("Client");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<Client>>(await response.Content.ReadAsStringAsync())
						?? throw new ArgumentNullException("Nenhum resultado encontrado");
				}
				else
				{
					MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
				}

				return list;
			}
			catch (ArgumentException ae)
			{
				MessageBox.Show(ae.Message, "Aconteceu um erro");
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
		public static async Task<List<Client>> Get(Guid id)
		{
			try
			{
				List<Client> list = null;

				HttpClient client = ConnectionFactory.ConnectionLocalhost();

				HttpResponseMessage response = await client.GetAsync($"Client/Search/{id}");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<Client>>(await response.Content.ReadAsStringAsync())
					?? throw new ArgumentNullException("Nenhum resulta encontrado");
				}
				else
				{
					MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
				}
				return list;
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

		#region GetSmart
		public static async Task<List<Client>> Get(string value)
		{
			try
			{
				List<Client> list = null;

				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync($"Client/Smart/{value}");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<Client>>(await response.Content.ReadAsStringAsync())
						?? throw new ArgumentNullException("Nunhum cliente encontrado!");
				}
				else
				{
					MessageBox.Show(await response.Content.ReadAsStringAsync());
				}

				return list;
			}
			catch(ArgumentException ae)
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

        #region Post
		public static async void Post(Client client)
		{
			string message = "";

			try		
			{
				HttpClient httpClient = ConnectionFactory.ConnectionLocalhost();

				HttpResponseMessage response = await httpClient.PostAsJsonAsync("Client", client);

				if (response.IsSuccessStatusCode)
				{
					message = await response.Content.ReadAsStringAsync();
				}
				else
				{
					message = await response.Content.ReadAsStringAsync();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
			}
		}
		#endregion

		#region Put
		public static async void Put(Client client)
		{
			string message = "";
			try
			{
				HttpClient httpClient = ConnectionFactory.ConnectionLocalhost();

				HttpResponseMessage response = await httpClient.PutAsJsonAsync("Client",client);

				if (response.IsSuccessStatusCode)
				{
					message = await response.Content.ReadAsStringAsync();
				}
				else
				{
					message += await response.Content.ReadAsStringAsync();
				}
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
			string message = "";
			bool result = false;

			try
			{
				HttpClient httpClient = ConnectionFactory.ConnectionLocalhost();

				HttpResponseMessage response = await httpClient.DeleteAsync($"Client/{id}");

				if (response.IsSuccessStatusCode)
				{
					message = await response.Content.ReadAsStringAsync();
				}
				else
				{
					message = await response.Content.ReadAsStringAsync();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
			}
		}
        #endregion
    }
}
