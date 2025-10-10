using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Service
{
    public class ItemReturnService
    {
        #region Get
        public static async Task<List<ItemReturn>> Get()
        {
			try
			{
				List<ItemReturn> list = null;

				HttpClient client = ConnectionFactory.ConnectionLocalhost();
				HttpResponseMessage response = await client.GetAsync("ItemReturn");

				if (response.IsSuccessStatusCode)
				{
					list = JsonConvert.DeserializeObject<List<ItemReturn>>(await response.Content.ReadAsStringAsync());
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

		#region GetId
		public static async Task<List<ItemReturn>> Get(Guid id)
		{
			try
			{

                List<ItemReturn> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"ItemReturn/{id}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<ItemReturn>>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync(), "Aconteceu um erro");
                }

                return list;
            }
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}" );
				return null;
			}
		}
        #endregion

        #region GetSmart
        public static async Task<List<ItemReturn>> Get(string value)
        {
            try
            {
                List<ItemReturn> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"ItemReturn/{value}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<List<ItemReturn>>(await response.Content.ReadAsStringAsync());
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

        #region GetIdReturn
        public static async Task<Guid> GetIdReturn(Guid returnId)
        {
            try
            {
                Guid id = Guid.Empty;
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"ItemReturn/returnId/{returnId}");

                if (response.IsSuccessStatusCode)
                {
                    id = JsonConvert.DeserializeObject<Guid>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return Guid.Empty;
            }
        }
        #endregion

        #region Post
        public static async Task<bool> Post(BindingList<ItemReturn> itens)
        {
            try
            {
                bool value = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("ItemReturn", itens);

                if (response.IsSuccessStatusCode)
                {
                    value = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                }

                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return false;
            }
        }
        #endregion

        #region Put
        public static async Task<bool> Put(BindingList<ItemReturn> itens)
        {
            try
            {
                bool value = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("ItemReturn", itens);

                if (response.IsSuccessStatusCode)
                {
                    value = JsonConvert.DeserializeObject<bool>(await response.Content.ReadAsStringAsync());
                }

                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return false;
            }
        }
        #endregion

        #region Delete
        public static async void Delete (Guid id)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.DeleteAsync($"ItemReturn/{id}");

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