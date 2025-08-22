using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class SletModel : SletPageModel<Bil>
{
	public SletModel(IBilRepository repo) : base(repo)
	{
	}
}


