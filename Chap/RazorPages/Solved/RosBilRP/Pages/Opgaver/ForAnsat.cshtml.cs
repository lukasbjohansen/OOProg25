using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class ForAnsatModel : PageModel
{
	private IAnsatRepository _repo;

	public List<Opgave> Data { get; private set; }

	public Ansat DenAnsatte { get; private set; }

	public ForAnsatModel(IAnsatRepository repo)
	{
		_repo = repo;
	}

	public void OnGet(int ansatId)
	{
		DenAnsatte = _repo.Read(ansatId) ?? throw new ArgumentException("Ansat ikke fundet...");
		Data = DenAnsatte.Opgaves.ToList();
	}
}
