using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Lejer;

public class OpretModel : PageModel
{
	private ILejeRepository _repo;

	[BindProperty]
	public Leje Element { get; set; } = new Leje();

	public SelectList KundeList { get; set; }
	public SelectList BilList { get; set; }

	public OpretModel(
		ILejeRepository repo,
		IKundeRepository kundeRepo,
		IBilRepository bilRepo)
	{
		_repo = repo;

		KundeList = new SelectList(kundeRepo.All, nameof(Kunde.Id), nameof(Kunde.Navn));
		BilList = new SelectList(bilRepo.All, nameof(Bil.Id), nameof(Bil.NummerpladeOgModel));

		Element.Dato = DateOnly.FromDateTime(DateTime.Now);
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

