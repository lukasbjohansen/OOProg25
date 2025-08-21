using ItemRazorV8.Models;
using ItemRazorV8.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV8.Pages.Customers
{
    public class EditCustomerModel : PageModel
    {
        private ICustomerService _customerService;

        public EditCustomerModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [BindProperty]
        public Customer Customer{ get; set; }

        public IActionResult OnGet(int id)
        {
            Customer = _customerService.GetCustomer(id);
            if (Customer == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _customerService.UpdateCustomer(Customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
