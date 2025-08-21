using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;

namespace ItemRazorV9.Pages.Customers
{
    public class CreateCustomerModel : CreatePageModelBase<Customer, ICustomerRepository>
    {
        public CreateCustomerModel(ICustomerRepository repository) 
            : base(repository, "GetAllCustomers")
        {
        }
    }
}
