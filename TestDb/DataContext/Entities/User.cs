using System;
using System.Collections.Generic;

#nullable disable

namespace TestDb.DataContext.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
