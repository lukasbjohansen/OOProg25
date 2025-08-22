using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class SletModel : SletPageModel<Opgave>
{
	public SletModel(IOpgaveRepository repo) : base(repo)
	{
	}
}
