using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV9.Pages.Orders
{
    public class CreateOrderModel : PageModel // NB: Her bruger vi IKKE vores egen base-klasse!
    {
        private IOrderRepository _orderRepo;
        private ICustomerRepository _customerRepo;

        public CreateOrderModel(IOrderRepository orderRepo, ICustomerRepository customerRepo)
        {
            _orderRepo = orderRepo;
            _customerRepo = customerRepo;
        }

        [BindProperty]
        public string OrderRemark { get; set; }

        [BindProperty]
        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }

        public IActionResult OnGet(int custId)
        {
            Customer = _customerRepo.Read(custId) ?? new Customer();
            CustomerId = custId;

            return Page();
        }

        public IActionResult OnPost()
        {
            if (CustomerId.HasValue)
            {
                Customer? customer = _customerRepo.Read(CustomerId.Value);
                Order newOrder = new Order(0, customer) { Remark = OrderRemark };
                int orderId = _orderRepo.Create(newOrder).Id;

                return RedirectToPage("EditOrder", new { id = orderId });
            }

            return RedirectToPage("GetAllOrders");
        }
    }
}
