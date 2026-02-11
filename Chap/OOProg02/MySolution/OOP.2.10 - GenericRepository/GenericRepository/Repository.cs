
public class Repository<K, V>
{
	private Dictionary<K, V> _dictionary;

	public Repository()
	{
		_dictionary = new Dictionary<K, V>();
	}

	public List<V> All
	{
		get { return _dictionary.Values.ToList(); }
	}

	public int Count
	{
		get { return _dictionary.Count; }
	}

	public void PrintAll()
	{
		foreach (V item in _dictionary.Values)
		{
			Console.WriteLine(item);
		}
	}

	public void Insert(K key, V generic)
	{
		if (!_dictionary.ContainsKey(key))
		{
			_dictionary.Add(key, generic);
		}
	}

	public void Delete(K key)
	{
		_dictionary.Remove(key);
	}
}