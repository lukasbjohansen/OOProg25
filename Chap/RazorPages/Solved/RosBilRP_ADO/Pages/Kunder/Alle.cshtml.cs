using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Kunder;

public class AlleModel : PageModel
{
	private IKundeRepository _repo;
	private ILejeRepository _lejeRepo;

	public List<Kunde> Data { get; private set; }

	public AlleModel(IKundeRepository repo, ILejeRepository lejeRepo)
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
		return _lejeRepo.GetLejeForKunde(id).Count == 0;
	}
}
