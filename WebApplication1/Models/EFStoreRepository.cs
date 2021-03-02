using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private AppContext context;

        public EFStoreRepository(AppContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public IQueryable<Customer> Customers => context.Customers;

    }
}
