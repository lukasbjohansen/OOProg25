using ItemRazorV0.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ItemRazorV0.Pages.Items
{
    public class ViewItemModel : PageModel
    {
		public Item TheItem { get; private set; }

		public void OnGet()
		{
			TheItem = new Item(1, "Keyboard", 399);
		}
	}
}
