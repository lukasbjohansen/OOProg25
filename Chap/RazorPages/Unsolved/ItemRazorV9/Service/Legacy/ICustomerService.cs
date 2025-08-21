using ItemRazorV9.Models;

namespace ItemRazorV9.Service.Legacy
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomer(int id);
        Customer DeleteCustomer(int? id);
        IEnumerable<Customer> NameSearch(string str);
    }
}
