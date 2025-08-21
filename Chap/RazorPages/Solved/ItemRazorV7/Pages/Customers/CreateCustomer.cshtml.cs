using ItemRazorV7.Models;
using ItemRazorV7.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV7.Pages.Customers
{
    public class CreateCustomerModel : PageModel
    {
        private ICustomerService _customerService;

        public CreateCustomerModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [BindProperty]
        public Customer Customer{ get; set; }

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
            _customerService.AddCustomer(Customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
