using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class UserResquest
    {
        public string Login { set; get; }
        public string Password { get; set; }
    }
}
