using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Ansatte;

public class OpretModel : PageModel
{
	private IAnsatRepository _repo;

	[BindProperty]
	public Ansat Element { get; set; } = new Ansat();

	public OpretModel(IAnsatRepository repo)
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
