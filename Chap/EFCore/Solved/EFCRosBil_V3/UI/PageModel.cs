
/// <summary>
/// Klasse som simulerer en PageModel-klasse i en Razor Pages app.
/// </summary>
public class PageModel<T> where T : IHarId
{
	private IRepository<T> _repository;

	public List<T> Data { get; private set; }

	public PageModel(IRepository<T> repository)
	{
		_repository = repository;

		Data = new List<T>();
	}

	public void OnGet()
	{
		Data = _repository.All;
	}
}
