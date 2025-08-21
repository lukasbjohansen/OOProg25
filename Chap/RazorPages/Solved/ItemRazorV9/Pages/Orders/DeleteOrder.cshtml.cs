using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;

namespace ItemRazorV9.Pages.Orders
{
    public class DeleteOrderModel : DeletePageModelBase<Order, IOrderRepository>
    {
        public DeleteOrderModel(IOrderRepository repository) 
            : base(repository, "GetAllOrders")
        {
        }
    }
}
