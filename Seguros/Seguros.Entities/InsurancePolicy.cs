using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Entities
{
    public class InsurancePolicy
    {
        public long IdInsurancePolicy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PolicyStart { get; set; }
        public string Term { get; set; }
        public decimal Price { get; set; }
        public int IdRiskType { get; set; }
        public string RiskName { get; set; }
        public int IdCoverage { get; set; }
        public string CoverageName { get; set; }
    }
}
