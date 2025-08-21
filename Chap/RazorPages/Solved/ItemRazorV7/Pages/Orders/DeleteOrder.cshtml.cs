using ItemRazorV7.Models;
using ItemRazorV7.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace ItemRazorV7.Pages.Orders
{
    public class DeleteOrderModel : PageModel
    {
        private IOrderService _orderService;

        public DeleteOrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Order Order{ get; set; }


        public IActionResult OnGet(int id)
        {
            Order = _orderService.GetOrder(id);
            if (Order == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Order deletedOrder = _orderService.DeleteOrder(Order.Id);
            if (deletedOrder == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return RedirectToPage("GetAllOrders");
        }
    }
}
