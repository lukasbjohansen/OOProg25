using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class AlleModel : AllePageModel<Kunde>
{
	public AlleModel(IKundeRepository repo) : base(repo)
	{
	}

	public override bool CanDelete(int id)
	{
		Kunde? kunde = Data.Find(k => k.Id == id);

		return (kunde != null && kunde.Lejes.Count == 0);
	}
}
