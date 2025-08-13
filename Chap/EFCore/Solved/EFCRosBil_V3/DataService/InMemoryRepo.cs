
public abstract class InMemoryRepo<T> : IRepository<T> where T : class, IHarId
{
	private Dictionary<int, T> _data;

	public InMemoryRepo()
	{
		_data = new Dictionary<int, T>();

		Populate();
	}

	public List<T> All
	{
		get { return _data.Values.ToList(); }
	}

	public virtual int Create(T t)
	{
		t.Id = NextId();
		_data[t.Id] = t;

		return t.Id;
	}

	public bool Delete(int id) 
	{
		return _data.Remove(id);
	}

	public T? Read(int id)
	{
		return _data.ContainsKey(id) ? _data[id] : null;
	}

	protected virtual void Populate()
	{
		// Default opførsel: fyld IKKE data i repo fra start
	}

	private int NextId()
	{
		return All.Select(t => t.Id).DefaultIfEmpty(0).Max() + 1;
	}
}
