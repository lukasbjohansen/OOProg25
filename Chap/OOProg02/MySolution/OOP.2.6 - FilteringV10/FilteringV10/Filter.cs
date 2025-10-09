
/// <summary>
/// Class capable on filtering a List of integers.
/// Current filtering condition:
/// Include values larger than 10.
/// </summary>
public static class Filter
{
	public static List<int> FilterValues(List<int> values, params IFilterCondition[] conditions)
    {
        List<int> filteredValues = new List<int>();

        foreach (var value in values)
        {
            bool meetsAllConditions = true;
			foreach (var condition in conditions)
            {
                if (!condition.Condition(value)) meetsAllConditions = false;
			}
            if (meetsAllConditions) filteredValues.Add(value);
		}

        return filteredValues;
    }
}