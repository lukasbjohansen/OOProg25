using ItemRazorV2.Models;

namespace ItemRazorV2.Service
{
    public interface IItemService
    {
        List<Item> GetItems();
        void AddItem(Item item);
    }
}
