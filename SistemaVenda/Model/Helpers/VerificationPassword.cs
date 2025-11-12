using SistemaVenda.br.pro.com.model.Helpers;
using SistemaVenda.br.pro.com.model;
using SistemaVenda.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda.Model.Helpers
{
    public class VerificationPassword
    {
        public static async Task<UserResponse> Verification(string password) 
        {

            string hash = PasswordGenerator.Generator(password);

            UserResponse response = await UserService.GetPassword(hash);

            if (response.User != null)
            {
                UserSession.Id = response.User.Id;
                UserSession.EmployeeId = response.User.EmployeeId;
                UserSession.Name = response.User.Name;
                UserSession.Login = response.User.Login;
                UserSession.Password = response.User.Password;
                UserSession.Token = response.Token;
            }

            return response;
        }
    }
}
