using System.Linq;


namespace ProjectTeamVitAspDotNetCore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private JwelleryContext context;
        public EFStoreRepository(JwelleryContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Product;
        public IQueryable<Category> Categories => context.Category;
        public IQueryable<Brand> Brands => context.Brand;
        public IQueryable<Color> Colors => context.Color;
        public IQueryable<Dim> Dims => context.Dim;
        public IQueryable<Metal> Metals => context.Metal;
        public IQueryable<Role> Roles => context.Role;
        public IQueryable<Stone> Stones => context.Stone;
        public IQueryable<User> Users => context.User;
    }
}
