using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Pages._Base;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class AlleModel : AllePageModel<Bil>
{
	public AlleModel(IBilRepository repo) : base(repo)
	{
	}

	public override bool CanDelete(int id)
	{
		Bil? bil = Data.Find(b => b.Id == id);

		return (bil != null && bil.Lejes.Count == 0);
	}
}
