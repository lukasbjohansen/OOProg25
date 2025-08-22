using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Lejer;

public class SletModel : SletPageModel<Leje>
{
	public SletModel(ILejeRepository repo) : base(repo)
	{
	}
}
