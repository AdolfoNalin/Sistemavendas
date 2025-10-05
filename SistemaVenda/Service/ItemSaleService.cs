using iTextSharp.text.io;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using SistemaVenda.br.pro.com.connection;
using SistemaVenda.br.pro.com.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Service
{
    public class ItemSaleService
    {
        #region Get
        public static async Task<BindingList<ItemSale>> Get(Guid idSale)
        {
            try
            {
                BindingList<ItemSale> list = null;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"ItemSale/{idSale}");

                if (response.IsSuccessStatusCode)
                {
                    list = JsonConvert.DeserializeObject<BindingList<ItemSale>>(await response.Content.ReadAsStringAsync());
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

        #region GetSaleID
        public static async Task<Guid> GetItemSale(Guid saleId)
        {
            try
            {
                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.GetAsync($"ItemSale/Sale/{saleId}");

                if (response.IsSuccessStatusCode)
                {
                    Guid itemSaleId = JsonConvert.DeserializeObject<Guid>(await response.Content.ReadAsStringAsync());
                    return itemSaleId;
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
                    return Guid.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return Guid.Empty;
            }
        }
        #endregion

        #region Post
        public static async Task<bool> Post(List<ItemSale> itens)
        {
            try
            {
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PostAsJsonAsync("ItemSale", itens);

                if (response.IsSuccessStatusCode)
                {
                    result = Boolean.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
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
        public static async Task<bool> Put(List<ItemSale> item)
        {
            try
            {
                bool result = false;

                HttpClient client = ConnectionFactory.ConnectionLocalhost();
                HttpResponseMessage response = await client.PutAsJsonAsync("ItemSale", item);

                if (response.IsSuccessStatusCode)
                {
                    result = Boolean.Parse(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show(await response.Content.ReadAsStringAsync());
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
