using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
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
        public async Task<List<ItemReturn>> Get()
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
		public async Task<List<ItemReturn>> Get(Guid id)
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
        public async Task<List<ItemReturn>> Get(string value)
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

        #region Post
        public async void Post(ItemReturn item)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("ItemReturn", item);

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

        #region Put
        public async void Put(ItemReturn item)
        {
            try
            {
                string message = "";

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("ItemReturn", item);

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

        #region Delete
        public async void Delete (Guid id)
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