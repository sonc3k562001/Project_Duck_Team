using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Recipe { get; set; }
        public string Note { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
