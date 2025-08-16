using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model.Helpers
{
    public static class PasswordGenerator
    {
        #region PasswordGenerator
        public static string Generator(string password)
        {
            string hashPassword;
            using(SHA256 pass = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] result = pass.ComputeHash(bytes);
                hashPassword = Encoding.UTF8.GetString(result);
            }

            return hashPassword;
        }
        #endregion
    }
}
