using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
#nullable disable

namespace WebShopRPV0.Pages.Products
{
    public class CreateModel : PageModel
    {
        private IProductDataService _productDataService;

        [BindProperty]
        public Product Data { get; set; } = new Product();

        public CreateModel(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        public IActionResult OnPost()
        {
            // Tjek om det indtastede data er validt
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Send data videre til data-service
            _productDataService.Create(Data);

            // Vend tilbage til Product-oversigen
            return RedirectToPage("All");
        }
    }
}
