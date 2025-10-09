public class DivisableBy3 : IFilterCondition
{
	public static DivisableBy3 Instance { get; } = new DivisableBy3();
	private DivisableBy3() { }
	public bool Condition(int value)
	{
		return value % 3 == 0;
	}
}
