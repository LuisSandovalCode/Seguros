using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Entities
{
    public class Customer
    {
        public int? IdCustomer { get; set; }
        public string Identification { get; set; } = null;
        public string Name { get; set; } = null;
        public string Telephone { get; set; } = null;
        public string Email { get; set; } = null;
        public string Adress { get; set; } = null;
        public long? IdInsurancePolicy { get; set; }
    }
}
