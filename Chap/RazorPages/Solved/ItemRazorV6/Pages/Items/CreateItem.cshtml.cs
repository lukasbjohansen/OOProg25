using ItemRazorV6.Models;
using ItemRazorV6.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV6.Pages.Items
{
    public class CreateItemModel : PageModel
    {
        private IItemService _itemService;

        public CreateItemModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        [BindProperty]
        public Item Item { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _itemService.AddItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
