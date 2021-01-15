using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Inquiry
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string EmailId { get; set; }
        public string Comment { get; set; }
        public DateTime Cdate { get; set; }
    }
}
