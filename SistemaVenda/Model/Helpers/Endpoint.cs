using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Model.Helpers
{
    public class Endpoint
    {
        public static string GetEndPoint()
        {
            try
            {
                string endpoint = Program.configuration.GetSection("SysComApplication:Endpoint").Value
                    ?? throw new ArgumentNullException("Endpoint não foi encontrado!");

                return endpoint;
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, "Algo deu errado!");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
