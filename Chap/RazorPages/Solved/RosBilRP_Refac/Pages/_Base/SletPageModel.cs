using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages._Base;

public class SletPageModel<T> : PageModel where T : IHarId
{
	private IRepository<T> _repo;

	[BindProperty]
	public T Element { get; set; }

	protected virtual string RedirectPage { get { return "Alle"; } }
	protected virtual string ErrorRedirectPage { get { return "Error"; } }

	public SletPageModel(IRepository<T> repo)
	{
		_repo = repo;
	}

	public virtual IActionResult OnGet(int id)
	{
		T? element = _repo.Read(id);

		if (element == null)
			return RedirectToPage(ErrorRedirectPage);

		Element = element;
		return Page();
	}

	public virtual IActionResult OnPost()
	{
		_repo.Delete(Element.Id);

		return RedirectToPage(RedirectPage);
	}
}
