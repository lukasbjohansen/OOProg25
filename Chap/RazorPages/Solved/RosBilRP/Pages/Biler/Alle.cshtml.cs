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

	public bool CanDelete(int id)
	{
		Bil? bil = Data.Find(b => b.Id == id);

		return (bil != null && bil.Lejes.Count == 0);
	}
}
