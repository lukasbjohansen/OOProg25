using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Interfaces;

namespace ItemRazorV8.Service.Repositories.Model
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);
    }
}
