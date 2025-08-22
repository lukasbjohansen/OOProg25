using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class ForLejeModel : PageModel
{
	private ILejeRepository _repo;

	public List<Opgave> Data { get; private set; }

	public Leje Lejen { get; private set; }

	public ForLejeModel(ILejeRepository repo)
	{
		_repo = repo;
	}

	public void OnGet(int lejeId)
	{
		Lejen = _repo.Read(lejeId) ?? throw new ArgumentException("Leje ikke fundet...");
		Data = Lejen.Opgaves.ToList();
	}
}
