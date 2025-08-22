using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Lejer;

public class AlleModel : AllePageModel<Leje>
{
	public AlleModel(ILejeRepository repo) : base(repo)
	{
	}
}

