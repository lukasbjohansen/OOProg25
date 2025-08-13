
public static class Helpers
{
    /// <summary>
    /// Udskriver en liste af objekter af typen T
    /// </summary>
    public static void PrintList<T>(List<T> data)
    {
        Console.WriteLine($"Alle {typeof(T).Name} ({data.Count} i alt)");
        Console.WriteLine("-----------------------------------");
        foreach (T t in data)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
    }

    public static int FindMaxId<T>(List<T> data) where T : IHarId
    {
        int maxId = data.Select(dr => dr.Id).DefaultIfEmpty(0).Max();
        return maxId;
    }
}
