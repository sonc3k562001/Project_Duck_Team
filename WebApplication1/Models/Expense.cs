using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Expense
    {
        public int Id { get; set; }
        

        [Required(ErrorMessage ="Title is Required")]
        [MaxLength(50,ErrorMessage ="Maxium 50")]
        [MinLength(3,ErrorMessage ="Minium 3")]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        public string PaidBy { get; set; }
        public string Description { get; set; }
    }
}
