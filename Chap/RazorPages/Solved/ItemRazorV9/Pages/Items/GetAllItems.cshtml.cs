using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;

namespace ItemRazorV9.Pages.Items
{
    public class GetAllItemsModel : GetAllPageModelBase<Item, IItemRepository>
    {
        [BindProperty] 
        public string SearchString { get; set; }

        [BindProperty]
        public int MinPrice { get; set; }

        [BindProperty]
        public int MaxPrice { get; set; }

        public GetAllItemsModel(IItemRepository repository) : base(repository)
        {
        }

        public IActionResult OnPostNameSearch()
        {
            Data = _repository.Search(SearchString).ToList();
            return Page();
        }

        public IActionResult OnPostPriceFilter()
        {
            Data = _repository.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }
    }
}
