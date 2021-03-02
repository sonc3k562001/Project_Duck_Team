﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoComplete.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set;}
        public bool Status { get; set; }
        public string Photo { get; set; }
    }
}
