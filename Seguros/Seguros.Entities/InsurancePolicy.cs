using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Entities
{
    public class InsurancePolicy
    {
        public long? IdInsurancePolicy { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public DateTime? PolicyStart { get; set; }
        public string Term { get; set; } = null;
        public decimal? Price { get; set; }
        public int? IdRisk { get; set; }
        public string RiskName { get; set; } = null;
        public int? IdCoverage { get; set; }
        public string CoverageName { get; set; } = null;
    }
}
