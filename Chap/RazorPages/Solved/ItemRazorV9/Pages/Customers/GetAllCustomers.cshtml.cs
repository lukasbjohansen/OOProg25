using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;

namespace ItemRazorV9.Pages.Customers
{
    public class GetAllCustomersModel : GetAllPageModelBase<Customer, ICustomerRepository>
    {
        [BindProperty]
        public string SearchString { get; set; }

        public GetAllCustomersModel(ICustomerRepository repository) : base(repository)
        {
            SearchString = "";
        }

        public IActionResult OnPostNameSearch()
        {
            Data = _repository.Search(SearchString).ToList();
            return Page();
        }
    }
}
