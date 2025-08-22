using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class AlleModel : PageModel
{
	private IOpgaveRepository _repo;

	public List<Opgave> Data { get; private set; }

	public AlleModel(IOpgaveRepository repo)
	{
		_repo = repo;
	}

	public void OnGet()
	{
		Data = _repo.All;
	}

	/// <summary>
	/// Vi kan altid slette Leje-objekter, da dette ikke kan resultere
	/// i problemer med fremmednøgler.
	/// </summary>
	public bool CanDelete(int id)
	{
		return true;
	}
}
