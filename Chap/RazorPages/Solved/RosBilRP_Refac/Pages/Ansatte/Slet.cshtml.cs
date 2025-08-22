using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Ansatte;

public class SletModel : SletPageModel<Ansat>
{
	public SletModel(IAnsatRepository repo) : base(repo)
	{
	}
}
