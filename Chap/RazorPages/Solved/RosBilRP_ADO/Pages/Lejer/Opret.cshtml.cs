using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Lejer;

public class OpretModel : PageModel
{
	private ILejeRepository _repo;
	private IKundeRepository _kundeRepo;
	private IBilRepository _bilRepo;

	//[BindProperty]
	//public Leje Element { get; set; } = new Leje();

	[BindProperty]
	public DateOnly Dato { get; set; }

	[BindProperty]
	public int AntalDage { get; set; }

	[BindProperty]
	public int SelectedKundeId { get; set; }

	[BindProperty]
	public int SelectedBilId { get; set; }


	public SelectList KundeList { get; set; }
	public SelectList BilList { get; set; }

	public OpretModel(
		ILejeRepository repo,
		IKundeRepository kundeRepo,
		IBilRepository bilRepo)
	{
		_repo = repo;
		_kundeRepo = kundeRepo;
		_bilRepo = bilRepo;

		KundeList = new SelectList(kundeRepo.All, nameof(Kunde.Id), nameof(Kunde.Navn));
		BilList = new SelectList(bilRepo.All, nameof(Bil.Id), nameof(Bil.NummerpladeOgModel));

		Dato = DateOnly.FromDateTime(DateTime.Now);
	}

	public IActionResult OnPost()
	{
		Kunde? kunden = _kundeRepo.Read(SelectedKundeId);
		Bil? bilen = _bilRepo.Read(SelectedBilId);

		if (kunden == null || bilen == null)
		{
			throw new Exception("Kunde eller Bil blev ikke fundet");
		}

		// Tjek om det indtastede data er validt
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// Send data videre til repository
		_repo.Create(new Leje(0, kunden, bilen, Dato, AntalDage));

		// Vend tilbage til oversigen
		return RedirectToPage("Alle");
	}
}

