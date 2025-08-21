using ItemRazorV3.Models;

namespace ItemRazorV3.Service
{
    public interface IItemService
    {
        List<Item> GetItems();
        void AddItem(Item item);
    }
}
