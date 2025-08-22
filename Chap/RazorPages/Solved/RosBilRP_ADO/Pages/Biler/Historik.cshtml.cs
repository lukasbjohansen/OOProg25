using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Biler;

public class HistorikModel : PageModel
{
	private IBilRepository _repo;
	private ILejeRepository _lejeRepo;

	public List<Leje> Data { get; private set; }

	public Bil Bilen { get; private set; }

	public HistorikModel(IBilRepository repo, ILejeRepository lejeRepo)
	{
		_repo = repo;
		_lejeRepo = lejeRepo;
	}

	public void OnGet(int bilId)
	{
		Bilen = _repo.Read(bilId) ?? throw new ArgumentException("Bil ikke fundet...");
		Data = _lejeRepo.GetLejeForBil(bilId);
	}
}
