using ItemRazorV2.MockData;
using ItemRazorV2.Models;

namespace ItemRazorV2.Service
{
    public class ItemService : IItemService
    {
        private List<Item> _items;

        public ItemService()
        {
            _items = MockItems.GetMockItems();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public List<Item> GetItems() { return _items; }
    }
}
