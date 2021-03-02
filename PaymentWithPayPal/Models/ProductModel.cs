using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentWithPayPal.Models
{
    public class ProductModel
    {
        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = "p1",
                    Name = "Name 1",
                    Photo = "sha.jpg",
                    Price = 4.5,
                    Quantity = 2
                },
                new Product
                {
                    Id = "p2",
                    Name = "Name 2",
                    Photo = "sha1.jpg",
                    Price = 4.7,
                    Quantity = 3
                },
                new Product
                {
                    Id = "p3",
                    Name = "Name 3",
                    Photo = "sha2.jpg",
                    Price =5.1,
                    Quantity = 8
                },
            };
        }
    }
}
