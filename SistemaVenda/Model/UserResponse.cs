using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class UserResponse
    {
        public static Guid Id { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static string Login { get; set; }
        public static string Function { get; set; }
        public static string Token { get; set; }
    }
}
