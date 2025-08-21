using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;

namespace ItemRazorV9.Pages.Orders
{
    public class GetAllOrdersModel : GetAllPageModelBase<Order, IOrderRepository>
    {
        public GetAllOrdersModel(IOrderRepository repo) : base(repo) 
        {
            CustomerSearchString = "";
        }

        [BindProperty]
        public string CustomerSearchString { get; set; }

        public IActionResult OnPostCustomerNameSearch()
        {
            Data = _repository.Search(CustomerSearchString).ToList();
            return Page();
        }
    }
}
