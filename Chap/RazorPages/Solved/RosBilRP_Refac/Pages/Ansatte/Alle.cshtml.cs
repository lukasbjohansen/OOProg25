using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Ansatte;

public class AlleModel : AllePageModel<Ansat>
{
	public AlleModel(IAnsatRepository repo) : base(repo)
	{
	}

	public override bool CanDelete(int id)
	{
		Ansat? ansat = Data.Find(b => b.Id == id);

		return (ansat != null && ansat.Opgaves.Count == 0);
	}
}
