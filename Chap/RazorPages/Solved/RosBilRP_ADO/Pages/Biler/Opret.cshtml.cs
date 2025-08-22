using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class OpretModel : PageModel
{
	private IBilRepository _repo;

	[BindProperty]
	public Bil Element { get; set; } = new Bil();

	public OpretModel(IBilRepository repo)
	{
		_repo = repo;
	}

	public IActionResult OnPost()
	{
		// Tjek om det indtastede data er validt
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// Send data videre til repository
		_repo.Create(Element);

		// Vend tilbage til oversigen
		return RedirectToPage("Alle");
	}
}
