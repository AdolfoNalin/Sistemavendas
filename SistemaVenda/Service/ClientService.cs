using Newtonsoft.Json;
using SistemaVenda.Model;
using SistemaVenda.br.pro.com.connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

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
		public static async Task<Client> Get(Guid id)
		{
			try
			{
				Client client = null;

				HttpClient clientHttp = ConnectionFactory.ConnectionLocalhost();

				HttpResponseMessage response = await clientHttp.GetAsync($"Client/search/{id}");

				if (response.IsSuccessStatusCode)
				{
					client = JsonConvert.DeserializeObject<Client>(await response.Content.ReadAsStringAsync())
					?? throw new ArgumentNullException("Nenhum resulta encontrado");
				}
				else
				{
					MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
				}
				return client;
			}
			catch (ArgumentException ae)
			{
				MessageBox.Show(ae.Message);
				return null;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
				return null;
			}
		}
        #endregion

        #region GetSmart
		public static async Task<List<Client>> Get(string value)
		{
			List<Client> list = new List<Client>();
			try
			{
				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync($"Client/Smart/{value}");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<Client>>(await response.Content.ReadAsStringAsync());
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
		public static async void Post(Client client)
		{
			try
			{
				string message = "";

				HttpClient clientHttp = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await clientHttp.PostAsJsonAsync("Client", client);

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
		public static async void Put(Client client)
		{
			try
			{
				string message = "";
				HttpClient clientHttp = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await clientHttp.PutAsJsonAsync("Client", client);

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
				HttpClient httpClient = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await httpClient.DeleteAsync($"Client/{id}");

				if (response.IsSuccessStatusCode)
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
