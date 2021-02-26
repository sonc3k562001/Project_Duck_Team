using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTeamVitAspDotNetCore.Services
{
    public class ItemProductService : IProduct
    {
        private readonly JwelleryContext _db;
        private List<Product> products = new List<Product>();
        public ItemProductService(JwelleryContext db)
        {
            _db = db;
            this.products = _db.Product.ToList();
        }
        public IEnumerable<Product> getProductAll()
        {
            return products;
        }
        public int totalProduct()
        {
            return products.Count;
        }
        public int numberPage(int totalProduct, int limit)
        {
            float numberpage = totalProduct / limit;
            return (int)Math.Ceiling(numberpage);
        }
        public IEnumerable<Product> paginationProduct(int start, int limit)
        {
            var data = (from s in _db.Product select s);
            var dataProduct = data.OrderByDescending(x => x.PdId).Skip(start).Take(limit);
            return dataProduct.ToList();
        }

    }
}
