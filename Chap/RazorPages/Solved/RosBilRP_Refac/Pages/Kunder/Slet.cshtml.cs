using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class SletModel : SletPageModel<Kunde>
{
	public SletModel(IKundeRepository repo) : base(repo)
	{
	}
}
