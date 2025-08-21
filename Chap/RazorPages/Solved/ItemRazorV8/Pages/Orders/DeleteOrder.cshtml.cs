using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV8.Pages.Orders
{
    public class DeleteOrderModel : PageModel
    {
        private IOrderRepository _repo;

        public DeleteOrderModel(IOrderRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Order Order { get; set; }


        public IActionResult OnGet(int id)
        {
            Order? order = _repo.Read(id);

            if (order != null)
                Order = order;
            else
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Order? deletedOrder = _repo.Delete(Order.Id);
            if (deletedOrder == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return RedirectToPage("GetAllOrders");
        }
    }
}
