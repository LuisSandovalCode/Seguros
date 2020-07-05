using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Entities
{
    public class CustomerPolicy
    {
        public long? IdCustomer { get; set; }
        public long? IdInsurancePolicy { get; set; }
        public decimal CoveragePercentage { get; set; }
    }
}
