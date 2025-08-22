using Microsoft.AspNetCore.Mvc.RazorPages;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages._Base;

public abstract class IdMatchPageModel<TElement, TData> : PageModel where TElement : IHarId
{
	private IRepository<TElement> _repo;

	public List<TData> Data { get; private set; }

	public TElement Element { get; private set; }

	public IdMatchPageModel(IRepository<TElement> repo)
	{
		_repo = repo;
	}

	public void OnGet(int id)
	{
		Element = _repo.Read(id) ?? throw new ArgumentException("Data ikke fundet...");
		Data = GetDataCollection().ToList();
	}

	public abstract ICollection<TData> GetDataCollection();
}
