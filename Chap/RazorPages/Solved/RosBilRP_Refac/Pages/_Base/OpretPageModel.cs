using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages._Base;

public class OpretPageModel<T> : PageModel where T :  IHarId, new()
{
	private IRepository<T> _repo;

	[BindProperty]
	public T Element { get; set; } = new T();

	protected virtual string RedirectPage { get { return "Alle"; } }

	public OpretPageModel(IRepository<T> repo)
	{
		_repo = repo;
	}

	public IActionResult OnPost()
	{
		// Tjek om det indtastede data er validt
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// Send data videre til repository
		_repo.Create(Element);

		// Vend tilbage til RedirectPage
		return RedirectToPage(RedirectPage);
	}
}
