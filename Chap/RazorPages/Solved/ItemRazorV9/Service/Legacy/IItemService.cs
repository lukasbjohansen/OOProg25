using ItemRazorV9.Models;

namespace ItemRazorV9.Service.Legacy
{
    public interface IItemService
    {
        List<Item> GetItems();
        void AddItem(Item item);
        void UpdateItem(Item item);
        Item GetItem(int id);
        Item DeleteItem(int? itemId);
        IEnumerable<Item> NameSearch(string str);
        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);
    }
}
