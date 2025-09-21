using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SistemaVenda.Model
{
    public class UserSession
    {
        public static Guid Id { get; set; }
        public static string Login  { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static Guid EmployeeId { get; set; }
        public static string Token { get; set; }
    }
}
