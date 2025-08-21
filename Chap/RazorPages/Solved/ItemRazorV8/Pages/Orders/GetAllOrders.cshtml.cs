using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV8.Pages.Orders
{
    public class GetAllOrdersModel : PageModel
    {
        private IOrderRepository _repo;

        public GetAllOrdersModel(IOrderRepository repo)
        {
            _repo = repo;
            CustomerSearchString = "";
        }

        public List<Order>? Orders { get; private set; }

        [BindProperty]
        public string CustomerSearchString { get; set; }

        public void OnGet()
        {
            Orders = _repo.GetAll().ToList();
        }

        public IActionResult OnPostCustomerNameSearch()
        {
            Orders = _repo.Search(CustomerSearchString).ToList();
            return Page();
        }
    }
}
