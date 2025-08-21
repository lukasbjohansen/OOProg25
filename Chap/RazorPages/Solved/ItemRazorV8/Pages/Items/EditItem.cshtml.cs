using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV8.Pages.Items
{
    public class EditItemModel : PageModel
    {
        private IItemRepository _repo;

        public EditItemModel(IItemRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Item Item { get; set; }

        public IActionResult OnGet(int id)
        {
            Item? item = _repo.Read(id);

            if (item != null)
                Item = item;
            else
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repo.Update(Item.Id, Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
