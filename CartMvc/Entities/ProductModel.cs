using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartMvc.Entities
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product {
                    Id = "p01",
                    Name = "Balo chống gù lưng",
                    Price = 120000,
                    Photo = "item1.jpg"
                },
                new Product {
                    Id = "p02",
                    Name = "Mũ tai bèo hươu cao cổ",
                    Price = 320000,
                    Photo = "item2.jpg"
                },
                new Product {
                    Id = "p03",
                    Name = "Thắt lưng trẻ em",
                    Price = 110000,
                    Photo = "item3.jpg"
                },
                new Product {
                    Id = "p04",
                    Name = "Váy hồng đính nơ trẻ em",
                    Price = 99000,
                    Photo = "item4.jpg"
                }
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }
    }
}
