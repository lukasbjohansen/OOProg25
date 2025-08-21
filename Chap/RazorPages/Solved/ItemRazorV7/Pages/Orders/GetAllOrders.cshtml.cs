using ItemRazorV7.Models;
using ItemRazorV7.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV7.Pages.Orders
{
    public class GetAllOrdersModel : PageModel
    {
        private IOrderService _orderService;

        public GetAllOrdersModel(IOrderService orderService)
        {
            _orderService = orderService;
            CustomerSearchString = string.Empty;
		}

        public List<Order>? Orders { get; private set; }

        [BindProperty]
        public string CustomerSearchString { get; set; }

        public void OnGet()
        {
            Orders = _orderService.GetOrders();
        }

        public IActionResult OnPostCustomerNameSearch()
        {
            Orders = _orderService.CustomerNameSearch(CustomerSearchString).ToList();
            return Page();
        }
    }
}
