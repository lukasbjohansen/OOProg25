public class CarRepository
{
    private Dictionary<string, Car> _cars;

    public CarRepository()
    {
        _cars = new Dictionary<string, Car>();
    }

    public List<Car> All
    {
        get { return _cars.Values.ToList(); }
    }

    public int Count
    {
        get { return _cars.Count; }
    }

	public void PrintAll()
	{
		foreach (Car item in _cars.Values)
		{
			Console.WriteLine(item);
		}
	}

	public void Insert(string licensePlate, Car car)
    {
        if (!_cars.ContainsKey(licensePlate))
        {
            _cars.Add(licensePlate, car);
        }
    }

    public void Delete(string licensePlate)
    {
        _cars.Remove(licensePlate);
    }
}