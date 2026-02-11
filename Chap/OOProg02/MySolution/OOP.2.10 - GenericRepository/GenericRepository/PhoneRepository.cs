
public class PhoneRepository
{
	private Dictionary<string, Phone> _phones;

	public PhoneRepository()
	{
		_phones = new Dictionary<string, Phone>();
	}

	public List<Phone> All
	{
		get { return _phones.Values.ToList(); }
	}

	public int Count
	{
		get { return _phones.Count; }
	}

	public void PrintAll()
	{
		foreach (Phone item in _phones.Values)
		{
			Console.WriteLine(item);
		}
	}

	public void Insert(string serialNo, Phone phone)
	{
		if (!_phones.ContainsKey(serialNo))
		{
			_phones.Add(serialNo, phone);
		}
	}

	public void Delete(string serialNo)
	{
		_phones.Remove(serialNo);
	}
}