using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class AlleModel : PageModel
{
	private IBilRepository _repo;

	public List<Bil> Data { get; private set; }

	public AlleModel(IBilRepository repo)
	{
		_repo = repo;
	}

	public void OnGet()
	{
		Data = _repo.All;
	}

	/// <summary>
	/// Denne metode afgør, om Bil-objektet med det givne id må slettes.
	/// Det må det kun, hvis der ikke er nogle Leje-objekter, der refererer
	/// til det. Det kan vi afgøre ud fra Lejes-property, idet den KUN vil
	/// være tom, hvis ingen Leje-objekter refererer til dette Bil-objekt.
	/// </summary>
	public bool CanDelete(int id)
	{
		Bil? bil = Data.Find(b => b.Id == id);

		return (bil != null && bil.Lejes.Count == 0);
	}
}
