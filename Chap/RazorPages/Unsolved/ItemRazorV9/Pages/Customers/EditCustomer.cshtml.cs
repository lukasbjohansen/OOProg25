using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV9.Pages.Customers
{
    public class EditCustomerModel : PageModel
    {
        private ICustomerRepository _repo;

        public EditCustomerModel(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public IActionResult OnGet(int id)
        {
            Customer? customer = _repo.Read(id);

            if (customer != null)
                Customer = customer;
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

            _repo.Update(Customer.Id, Customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
