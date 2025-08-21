using ItemRazorV6.Models;

namespace ItemRazorV6.Service
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
