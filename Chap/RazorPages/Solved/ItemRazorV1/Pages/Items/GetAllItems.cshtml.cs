using ItemRazorV1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV1.Pages.Items
{
    public class GetAllItemsModel : PageModel
    {
        public List<Item> Items { get; private set; } = new List<Item> 
        {
            new Item(1, "PC", 5999),
            new Item(2, "Monitor", 1999),
            new Item(3, "Keyboard", 999)
        };

        public void OnGet()
        {
        }
    }
}
