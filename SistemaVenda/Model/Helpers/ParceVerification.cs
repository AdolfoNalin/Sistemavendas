using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Model.Helpers
{
    public class ParceVerification
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

        #region ParseDouble
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

        #region ParseDouble
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
    }
}
