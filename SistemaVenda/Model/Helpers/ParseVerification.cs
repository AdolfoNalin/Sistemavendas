using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Model.Helpers
{
    public class ParseVerification
    {
        #region ParseString
        public static String ParseString(string value, string message)
        {
            try
            {
                if (!String.IsNullOrEmpty(value))
                {
                    return value;
                }
                else 
                {
                    throw new ArgumentNullException(message);
                }
            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return null;
            }
        }
        #endregion

        #region ParseDouble
        public static Double ParseDouble(string value, string message)
        {
            try
            {
                double result = 0;

                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(message);
                }
                else if(!Double.TryParse(value, out result))
                {
                    throw new FormatException("Valor inválido");
                }

                return result;

            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
                return 0;
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace},{ex.HelpLink}");
                return 0;
            }
        }
        #endregion

        #region ParseDecimal
        public static Decimal ParseDecimal(string value, string message)
        {
            try
            {
                decimal result = 0;

                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(message);
                }
                else if (!Decimal.TryParse(value, out result))
                {
                    throw new FormatException("Valor inválido");
                }

                return result;

            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
                return 0;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace},{ex.HelpLink}");
                return 0;
            }
        }
        #endregion

        #region ParseGuid
        public static Guid ParseGuid(string value, string message)
        {
            try
            {
                Guid result = Guid.Empty;

                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(message);
                }
                else if (!Guid.TryParse(value, out result))
                {
                    throw new FormatException("Valor inválido");
                }

                return result;

            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.ParamName);
                return Guid.Empty;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return Guid.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace},{ex.HelpLink}");
                return Guid.Empty;
            }
        }
        #endregion

        #region ParseDaTeTime
        public static DateTime ParseDateTime(string value, string message)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Verifique se a data não está vazia!");
                }
                else if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Argumento Nullo", "Verifique se o valor data está correto");
                }

                DateTime.TryParse(value, out DateTime result);
                return result;
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                return new DateTime();
            }
            catch(FormatException ae)
            {
                MessageBox.Show(message);
                return new DateTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}, {ex.StackTrace}, {ex.HelpLink}");
                return new DateTime();
            }
        }
        #endregion
    }
}
