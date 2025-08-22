using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class HistorikModel : IdMatchPageModel<Kunde, Leje>
{
	public HistorikModel(IKundeRepository repo) : base(repo)
	{
	}

	public override ICollection<Leje> GetDataCollection()
	{
		return Element.Lejes.OrderBy(leje => leje.Dato).ToList();
	}
}
