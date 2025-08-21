using ItemRazorV3.Models;
using ItemRazorV3.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV3.Pages.Items
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
