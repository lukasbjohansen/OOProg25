using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class OpretModel : OpretPageModel<Bil>
{
	public OpretModel(IBilRepository repo) : base(repo)
	{
	}
}
