using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Interfaces;

namespace ItemRazorV9.Service.Repositories.Model
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);
    }
}
