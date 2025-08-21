using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Base;

namespace ItemRazorV8.Service.Repositories.Model
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IWebHostEnvironment WebHostEnvironment)
            : base(new JsonFileRepositoryBase<Customer>(WebHostEnvironment, "Customers.json"))
        {
        }

        protected override bool SearchMatch(Customer t, string str)
        {
            return string.IsNullOrEmpty(str) || t?.Name?.ToLower().Contains(str.ToLower()) == true;
        }
    }
}
