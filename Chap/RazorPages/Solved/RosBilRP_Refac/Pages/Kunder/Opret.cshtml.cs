using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class OpretModel : OpretPageModel<Kunde>
{
	public OpretModel(IKundeRepository repo) : base(repo)
	{
	}
}
