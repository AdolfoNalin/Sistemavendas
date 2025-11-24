using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string SupplierName{ get; set; }
        public string ShortDescription { get; set; }
        public decimal EntryPrice { get; set; }
        public double Amount { get; set; }
        public string UniMeasure { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
