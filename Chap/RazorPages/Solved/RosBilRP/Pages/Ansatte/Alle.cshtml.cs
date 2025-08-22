using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Ansatte;

public class AlleModel : PageModel
{
	private IAnsatRepository _repo;

	public List<Ansat> Data { get; private set; }

	public AlleModel(IAnsatRepository repo)
	{
		_repo = repo;
	}

	public void OnGet()
	{
		Data = _repo.All;
	}

	public bool CanDelete(int id)
	{
		Ansat? ansat = Data.Find(b => b.Id == id);

		return (ansat != null && ansat.Opgaves.Count == 0);
	}
}
