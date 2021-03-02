
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class AppContext:DbContext
    {
        public AppContext() : base("Server=(localdb)\\MSSQLLocalDB;Database=AppContext;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }
        /*ublic AppContext(DbContextOptions<AppContext> options) : base(options) { }
*/

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
