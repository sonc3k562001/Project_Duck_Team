using System.Linq;


namespace ProjectTeamVitAspDotNetCore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Brand> Brands { get; }
        IQueryable<Color> Colors { get; }
        IQueryable<Dim> Dims { get; }
        IQueryable<Metal> Metals { get; }
        IQueryable<Role> Roles { get; }
        IQueryable<Stone> Stones { get; }
        IQueryable<User> Users { get; }
    }
}
