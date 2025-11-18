
public class Person
{
    private double _height;
    private double _weight;

    /// <summary>
    /// Height in Meters (must be in the interval 0.2 to 3.0)
    /// </summary>
	public double Height 
    {
        get { return _height; }
        set 
        { 
            if (value < 0.2 || value > 3.0)
            {
                throw new ArgumentException("Height must be in the interval 0.2 to 3.0 meters.");
			}
            if (Weight != 0)
            {
				double newBMI = Weight / (value * value);
				if (newBMI < 5.0 || newBMI > 200.0)
				{
					throw new ArgumentException("The resulting BMI would be out of the valid range (5.0 to 200.0) with the given height.");
				}
			}	
			_height = value;
		}
	}

    /// <summary>
    /// Weight in Kilograms (must be in the interval 0.2 to 500.0)
    /// </summary>
    public double Weight 
    {
        get { return _weight; }
        set 
        {
            if (value < 0.2 || value > 500.0)
            {
                throw new ArgumentException("Weight must be in the interval 0.2 to 500.0 kilograms.");
            }
            if (Height != 0)
            {
				double newBMI = value / (Height * Height);
				if (newBMI < 5.0 || newBMI > 200.0)
				{
					throw new ArgumentException("The resulting BMI would be out of the valid range (5.0 to 200.0) with the given weight.");
				}
			}
			_weight = value; 
        }
    }

    /// <summary>
    /// Must be at least 2 characters long.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Must be in the interval 5.0 to 200.0
    /// </summary>
    public double BMI { get { return Weight / (Height * Height); } }

    public Person(string name, double height, double weight)
    {
        if (name.Length < 2)
        {
            throw new ArgumentException("Name must be at least 2 characters long.");
		}
		Name = name;
        Height = height;
        Weight = weight;
    }

    public void UpdateFromOther(Person other)
    {
        Height = other.Height;
        Weight = other.Weight;
    }
}

