using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Model
{
    public class SupplierDTO
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string PhoneNumber { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhoods { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
    }
}
