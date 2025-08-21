using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV8.Pages.Items
{
    public class CreateItemModel : PageModel
    {
        private IItemRepository _repo;

        public CreateItemModel(IItemRepository repo)
        {
            _repo = repo;
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

            _repo.Create(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
