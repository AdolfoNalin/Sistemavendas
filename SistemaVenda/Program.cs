using Microsoft.Extensions.Configuration;
using SistemaVenda.View;
using SistemaVenda.br.pro.com.view;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SistemaVenda.View;

namespace SistemaVenda
{
    internal static class Program
    {
        public static IConfiguration configuration;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            configuration = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
