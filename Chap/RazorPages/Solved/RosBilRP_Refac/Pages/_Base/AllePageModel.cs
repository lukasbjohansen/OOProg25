using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages._Base;

public class AllePageModel<T> : PageModel where T : IHarId
{
	private IRepository<T> _repo;

	public List<T> Data { get; private set; }

	public AllePageModel(IRepository<T> repo)
	{
		_repo = repo;
	}

	public void OnGet()
	{
		Data = _repo.All;
	}

	public virtual bool CanDelete(int id)
	{
		return true;
	}
}
