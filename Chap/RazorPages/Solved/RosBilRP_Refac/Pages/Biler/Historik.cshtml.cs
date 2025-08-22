using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class HistorikModel : IdMatchPageModel<Bil, Leje>
{
	public HistorikModel(IBilRepository repo) : base(repo)
	{
	}

	public override ICollection<Leje> GetDataCollection()
	{
		return Element.Lejes.OrderBy(leje => leje.Dato).ToList();
	}
}