using Microsoft.AspNetCore.Mvc.Rendering;
using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class OpretModel : OpretPageModel<Opgave>
{
	public SelectList AnsatList { get; set; }
	public SelectList LejeList { get; set; }

	public OpretModel(
		IOpgaveRepository repo,
		IAnsatRepository ansatRepo,
		ILejeRepository lejeRepo) : base(repo)
	{
		AnsatList = new SelectList(ansatRepo.All, nameof(Ansat.Id), nameof(Ansat.Navn));
		LejeList = new SelectList(lejeRepo.All, nameof(Leje.Id), nameof(Leje.Beskrivelse));

		Element.Afsluttet = false;
	}
}
