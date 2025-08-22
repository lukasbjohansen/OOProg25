using Microsoft.AspNetCore.Mvc.Rendering;
using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Lejer;

public class OpretModel : OpretPageModel<Leje>
{
	public SelectList KundeList { get; set; }
	public SelectList BilList { get; set; }

	public OpretModel(
		ILejeRepository repo,
		IKundeRepository kundeRepo,
		IBilRepository bilRepo) : base(repo)
	{
		KundeList = new SelectList(kundeRepo.All, nameof(Kunde.Id), nameof(Kunde.Navn));
		BilList = new SelectList(bilRepo.All, nameof(Bil.Id), nameof(Bil.NummerpladeOgModel));

		Element.Dato = DateOnly.FromDateTime(DateTime.Now);
	}
}

