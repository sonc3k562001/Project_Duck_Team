using System.Linq;


namespace DrinkStores.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
