using ItemRazorV6.Models;
using ItemRazorV6.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV6.Pages.Customers
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
