using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class AlleModel : PageModel
{
	private IBilRepository _repo;
	private ILejeRepository _lejeRepo;

	public List<Bil> Data { get; private set; }

	public AlleModel(IBilRepository repo, ILejeRepository lejeRepo)
	{
		_repo = repo;
		_lejeRepo = lejeRepo;
	}

	public void OnGet()
	{
		Data = _repo.All;
	}

	public bool CanDelete(int id)
	{
		return _lejeRepo.GetLejeForBil(id).Count == 0;
	}
}
