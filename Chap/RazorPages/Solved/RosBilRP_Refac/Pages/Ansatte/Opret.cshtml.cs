using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Ansatte;

public class OpretModel : OpretPageModel<Ansat>
{
	public OpretModel(IAnsatRepository repo) : base(repo)
	{
	}
}
