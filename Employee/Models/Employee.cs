using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Img { get; set; }
    }
}
