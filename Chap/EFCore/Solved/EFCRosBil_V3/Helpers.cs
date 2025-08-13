
public static class Helpers
{
    /// <summary>
    /// Udskriver en liste af Kunde-objekter
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
}
