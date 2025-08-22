using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class ForAnsatModel : IdMatchPageModel<Ansat, Opgave>
{
	public ForAnsatModel(IAnsatRepository repo) : base(repo)
	{
	}

	public override ICollection<Opgave> GetDataCollection()
	{
		return Element.Opgaves;
	}
}