using ItemRazorV4.Models;
using ItemRazorV4.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV4.Pages.Items
{
    public class EditItemModel : PageModel
    {
        private IItemService _itemService;

        public EditItemModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        [BindProperty]
        public Item Item { get; set; }

        public IActionResult OnGet(int id)
        {
			Item? item = _itemService.GetItem(id);
			if (item == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			Item = item;

			return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _itemService.UpdateItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
