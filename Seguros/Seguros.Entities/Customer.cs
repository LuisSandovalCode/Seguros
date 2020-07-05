﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Entities
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public long IdInsurancePolicy { get; set; }
    }
}
