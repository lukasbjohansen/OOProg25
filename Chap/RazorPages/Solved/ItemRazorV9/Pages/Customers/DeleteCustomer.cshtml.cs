using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;

namespace ItemRazorV9.Pages.Customers
{
    public class DeleteCustomerModel : DeletePageModelBase<Customer, ICustomerRepository>
    {
        public DeleteCustomerModel(ICustomerRepository repository) 
            : base(repository, "GetAllCustomers")
        {
        }
    }
}
