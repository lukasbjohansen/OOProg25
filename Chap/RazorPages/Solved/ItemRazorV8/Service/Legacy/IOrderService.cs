using ItemRazorV8.Models;

namespace ItemRazorV8.Service.Legacy
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Order GetOrder(int id);
        Order DeleteOrder(int? id);
        IEnumerable<Order> CustomerNameSearch(string str);
    }
}
