public abstract class Employee
{
	public string Name { get; }
	public int HoursPerWeek { get; set; }
	public virtual string AllInformation
	{
		get
		{
			return $"Employee {Name} works {HoursPerWeek} hours/week";
		}
	}
	public Employee(string name, int hoursPerWeek)
	{
		Name = name;
		HoursPerWeek = hoursPerWeek;
	}
}
