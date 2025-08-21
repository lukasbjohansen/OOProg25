using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV8.Pages.Customers
{
    public class GetAllCustomersModel : PageModel
    {
        private ICustomerRepository _repo;

        public GetAllCustomersModel(ICustomerRepository repo)
        {
            _repo = repo;
            SearchString = "";
        }

        public List<Customer>? Customers { get; private set; }

        [BindProperty]
        public string SearchString { get; set; }

        public void OnGet()
        {
            Customers = _repo.GetAll().ToList();
        }

        public IActionResult OnPostNameSearch()
        {
            Customers = _repo.Search(SearchString).ToList();
            return Page();
        }
    }
}
