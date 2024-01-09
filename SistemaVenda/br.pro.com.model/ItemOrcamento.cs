using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class ItemOrcamento : ItemVenda
    {
        public int CodigoOrcamento{ get; set; }
        public Produto Produtos { get; set; }
    }
}
