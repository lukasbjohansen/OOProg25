using ItemRazorV7.Models;
using ItemRazorV7.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV7.Pages.Customers
{
    public class GetAllCustomersModel : PageModel
    {
        private ICustomerService _customerService;

        public GetAllCustomersModel(ICustomerService customerService)
        {
            _customerService = customerService;
            SearchString = string.Empty;
        }

        public List<Customer>? Customers { get; private set; }

        [BindProperty]
        public string SearchString { get; set; }

        public void OnGet()
        {
            Customers = _customerService.GetCustomers();
        }

        public IActionResult OnPostNameSearch()
        {
            Customers = _customerService.NameSearch(SearchString).ToList();
            return Page();
        }
    }
}
