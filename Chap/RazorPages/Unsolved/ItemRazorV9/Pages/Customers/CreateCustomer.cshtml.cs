using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV9.Pages.Customers
{
    public class CreateCustomerModel : PageModel
    {
        private ICustomerRepository _repo;

        public CreateCustomerModel( ICustomerRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Customer Customer { get; set; }

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

            _repo.Create(Customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
