using ItemRazorV7.Models;
using ItemRazorV7.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV7.Pages.Items
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
