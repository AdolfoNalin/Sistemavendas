using SistemaVenda.Model;
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
        public User User { get; set; }
        public string Token { get; set; }
    }
}
