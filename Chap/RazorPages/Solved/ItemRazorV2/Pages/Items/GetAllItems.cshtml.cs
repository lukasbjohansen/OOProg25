using ItemRazorV2.Models;
using ItemRazorV2.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV2.Pages.Items
{
    public class GetAllItemsModel : PageModel
    {
        private IItemService _itemService;

        public GetAllItemsModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        public List<Item>? Items { get; private set; }

        public void OnGet()
        {
            Items = _itemService.GetItems();
        }
    }
}
