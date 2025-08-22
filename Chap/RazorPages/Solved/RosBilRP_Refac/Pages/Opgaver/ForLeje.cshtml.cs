using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class ForLejeModel : IdMatchPageModel<Leje, Opgave>
{
	public ForLejeModel(ILejeRepository repo) : base(repo)
	{
	}

	public override ICollection<Opgave> GetDataCollection()
	{
		return Element.Opgaves;
	}
}