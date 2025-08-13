
public abstract class SmartRepository<T>
{
	private List<T> _data;

	public SmartRepository()
	{
		_data = new List<T>();

		IndlæsData();
	}

	public List<T> HentAlle()
	{
		return _data;
	}

	public List<T> HentHvorDetGælderAt(Predicate<T> pred)
	{
		return _data.FindAll(pred);
	}

	protected void Indsæt(T t)
	{
		_data.Add(t);
	}

	/// <summary>
	/// Denne metode skal overrides i en sub-klasse
	/// </summary>
	protected abstract void IndlæsData();
}