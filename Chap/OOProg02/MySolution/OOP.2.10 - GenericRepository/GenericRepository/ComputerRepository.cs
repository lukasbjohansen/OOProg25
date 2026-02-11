
public class ComputerRepository
{
	private Dictionary<string, Computer> _computers;

	public ComputerRepository()
	{
		_computers = new Dictionary<string, Computer>();
	}

	public List<Computer> All
	{
		get { return _computers.Values.ToList(); }
	}

	public int Count
	{
		get { return _computers.Count; }
	}

	public void PrintAll()
	{
		foreach (Computer item in _computers.Values)
		{
			Console.WriteLine(item);
		}
	}

	public void Insert(string serialNo, Computer computer)
	{
		if (!_computers.ContainsKey(serialNo))
		{
			_computers.Add(serialNo, computer);
		}
	}

	public void Delete(string serialNo)
	{
		_computers.Remove(serialNo);
	}
}