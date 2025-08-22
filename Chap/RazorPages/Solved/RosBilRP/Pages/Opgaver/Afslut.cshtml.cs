using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Services;

namespace RosBilRP.Pages.Opgaver;

public class AfslutModel : PageModel
{
	private IOpgaveRepository _repo;

	public AfslutModel(IOpgaveRepository repo)
	{
		_repo = repo;
	}

	public IActionResult OnGet(int id)
    {
		_repo.Afslut(id);

		return RedirectToPage("Alle");
	}
}
