using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public long Id { get; set; }

        public string CustomerName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }

        public string Address { get; set; }
    }
}
