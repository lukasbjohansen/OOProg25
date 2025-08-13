
/// <summary>
/// Klasse som simulerer en "Vis Alle objekter"-Page i en Razor Pages app.
/// </summary>
public class Page<T> where T : IHarId
{
	public PageModel<T> Model { get; }

	public Page(PageModel<T> model)
	{
		Model = model;
	}

	public string Render()
	{
		Model.OnGet();

		string pageStr = $"---- Alle {typeof(T).Name}-objekter ----\n";
		foreach (T t in Model.Data)
		{
			pageStr += $"{t}\n";
		}
		pageStr += $"\n";

		return pageStr;
	}
}
