
public class ValueOver10 : IFilterCondition
{
	public static ValueOver10 Instance { get; } = new ValueOver10();
	private ValueOver10() { }
	public bool Condition(int value)
	{
		return value > 10;
	}
}
