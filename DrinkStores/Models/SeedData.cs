using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DrinkStores.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Water",
                        Description = "this is a category use for drink",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR-ByIsaD6_4OEws2O3jVZzZqn_gTw5iEdqfA&usqp=CAU",
                        Price = 123,
                        Discount = 1,
                        Category = "Tea",
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "I Tried",
                        Description = "this is a category use for drink",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR-ByIsaD6_4OEws2O3jVZzZqn_gTw5iEdqfA&usqp=CAU",
                        Price = 123,
                        Category = "Tea",
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Mikl Tea",
                        Description = "this is a category use for drink",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR-ByIsaD6_4OEws2O3jVZzZqn_gTw5iEdqfA&usqp=CAU",
                        Price = 123,
                        Category = "Tea",
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Black Coffee",
                        Description = "this is a category use for drink",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR-ByIsaD6_4OEws2O3jVZzZqn_gTw5iEdqfA&usqp=CAU",
                        Price = 1123,
                        Category = "Coffee",
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Brown Coffee",
                        Description = "this is a category use for drink",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR-ByIsaD6_4OEws2O3jVZzZqn_gTw5iEdqfA&usqp=CAU",
                        Price = 123,
                        Category = "Coffee",
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "White Coffee",
                        Description = "this is a category use for drink",
                        Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR-ByIsaD6_4OEws2O3jVZzZqn_gTw5iEdqfA&usqp=CAU",
                        Price = 123,
                        Category="Coffee",
                        Discount = 2,
                        Status = "stocking"
                    }
                    ); ;
                context.SaveChanges();
            }
        }
    }
}
