using ItemRazorV7.Models;

namespace ItemRazorV7.Service
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
