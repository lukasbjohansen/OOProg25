using ItemRazorV9.Base;
using ItemRazorV9.Models;
using ItemRazorV9.Service.Repositories.Model;

namespace ItemRazorV9.Pages.Items
{
    public class EditItemModel : EditPageModelBase<Item, IItemRepository>
    {
        public EditItemModel(IItemRepository repository) 
            : base(repository, "GetAllItems")
        {
        }
    }
}
