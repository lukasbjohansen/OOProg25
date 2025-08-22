using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class AlleModel : AllePageModel<Opgave>
{
	public AlleModel(IOpgaveRepository repo) : base(repo)
	{
	}
}
