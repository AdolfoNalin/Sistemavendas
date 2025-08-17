using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SistemaVenda.Model.Helpers;
using System.Management;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.Model;

namespace SistemaVenda.br.pro.com.connection
{
    public class ConnectionFactory
    {
        public static HttpClient ConnectionLocalhost()
        {
            string endpoint = SistemaVenda.Model.Helpers.Endpoint.GetEndPoint();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserSession.Token);
            client.Timeout = new TimeSpan(0, 0, 30);

            return client;
        }

        public static HttpClient ConnectionLocalhostUser()
        {
            string endpoint = SistemaVenda.Model.Helpers.Endpoint.GetEndPoint();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(endpoint);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = new TimeSpan(0, 0, 30);

            return client;
        }
    }
}
