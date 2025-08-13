
public static class Helpers
{
    /// <summary>
    /// Udskriver en liste af objekter af typen T
    /// </summary>
    public static void PrintList<T>(string typeName, List<T> data)
    {
        Console.WriteLine($"Alle {typeName}-objekter ({data.Count} i alt)");
        Console.WriteLine("-----------------------------------");
        foreach (T t in data)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
    }


	/// <summary>
	/// Finder det højeste brugte Id for Kunde-objekter.
	/// </summary>
	public static int FindMaxId(List<Kunde> kunder)
    {
		int maxId = kunder.Select(dr => dr.Id).DefaultIfEmpty(0).Max();
        return maxId;
	}
}
