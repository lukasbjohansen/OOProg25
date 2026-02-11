
public class EmployeeRepository
{
    private Dictionary<string, Employee> _employees;

    public EmployeeRepository()
    {
        _employees = new Dictionary<string, Employee>();
    }

    public List<Employee> All
    {
        get { return _employees.Values.ToList(); }
    }

	public int Count
	{
		get { return _employees.Count; }
	}

	public void PrintAll()
	{
		foreach (Employee item in _employees.Values)
		{
			Console.WriteLine(item);
		}
	}

	public void Insert(string name, Employee employee)
    {
        if (!_employees.ContainsKey(name))
        {
            _employees.Add(name, employee);
        }
    }

    public void Delete(string name)
    {
        _employees.Remove(name);
    }
}