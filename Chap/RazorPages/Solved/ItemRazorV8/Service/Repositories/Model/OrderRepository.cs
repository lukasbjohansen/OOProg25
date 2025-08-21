using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Base;

namespace ItemRazorV8.Service.Repositories.Model
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IWebHostEnvironment WebHostEnvironment)
            : base(new JsonFileRepositoryBase<Order>(WebHostEnvironment, "Orders.json"))
        {
        }

        protected override bool SearchMatch(Order t, string str)
        {
            return string.IsNullOrEmpty(str) || t.Customer?.Name?.ToLower().Contains(str.ToLower()) == true;
        }
    }
}
