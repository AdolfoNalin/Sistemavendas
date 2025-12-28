using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.br.pro.com.model.Helpers
{
    public class SearchCEP
    {
        #region SearchCep
		/// <summary>
		/// Search CEP
		/// </summary>
		/// <param name="cep">Cep válido</param>
		/// <returns></returns>
        public static City SearchCity(string cep)
        {
			try
			{
                string xmlUrl = "https://viacep.com.br/ws/" + cep + "/xml";
                DataSet dado = new DataSet();
                dado.ReadXml(xmlUrl);

				if (dado.Tables[0].Columns.Contains("erro"))
				{
					throw new NullReferenceException("Nenhum resultado encontrado");
				}
				else
				{
                    City city = new City()
                    {
                        Name = dado.Tables[0].Rows[0]["localidade"].ToString() ?? throw new ArgumentNullException("Cidade não existe"),
                        Street = dado.Tables[0].Rows[0]["logradouro"].ToString() ?? throw new ArgumentNullException("Rua não existe"),
                        Neighborhood = dado.Tables[0].Rows[0]["bairro"].ToString() ?? throw new ArgumentNullException("Baiiro não existe"),
                        Complement = dado.Tables[0].Rows[0]["complemento"].ToString(),
                        UF = dado.Tables[0].Rows[0]["uf"].ToString() ?? throw new ArgumentNullException("Estado não existe"),
                    };

					return city;
                }
			}
			catch (ArgumentNullException ae)
			{
				MessageBox.Show($"{ae.ParamName} \n {ae.Message}");
				return null;
			}
			catch(NullReferenceException ne)
			{
				MessageBox.Show(ne.Message);
				return null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
        }
        #endregion
    }
}
