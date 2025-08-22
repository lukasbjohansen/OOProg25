using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Lejer;

public class AlleModel : PageModel
{
	private ILejeRepository _repo;

	public List<Leje> Data { get; private set; }

	public AlleModel(ILejeRepository repo)
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

