using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class OpretModel : PageModel
{
	private IOpgaveRepository _repo;

	[BindProperty]
	public Opgave Element { get; set; } = new Opgave();

	public SelectList AnsatList { get; set; }
	public SelectList LejeList { get; set; }

	public OpretModel(
		IOpgaveRepository repo,
		IAnsatRepository ansatRepo,
		ILejeRepository lejeRepo)
	{
		_repo = repo;

		AnsatList = new SelectList(ansatRepo.All, nameof(Ansat.Id), nameof(Ansat.Navn));
		LejeList = new SelectList(lejeRepo.All, nameof(Leje.Id), nameof(Leje.Beskrivelse));

		Element.Afsluttet = false;
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
