
public static class Helpers
{
    /// <summary>
    /// Udskriver en liste af objekter af typen T
    /// </summary>
    public static void PrintList<T>(List<T> data)
    {
        Console.WriteLine($"Alle {typeof(T).Name}-objekter ({data.Count} i alt)");
        Console.WriteLine("-----------------------------------");
        foreach (T t in data)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
    }

	public static Leje CreateLeje(int id, int kundeId, int bilId, DateOnly dato, int antalDage, DataService dataService)
	{
		Kunde? kunde = dataService.Kunder.Read(kundeId);
		Bil? bil = dataService.Biler.Read(bilId);

		if (kunde == null || bil == null)
		{
			throw new Exception("Kunne ikke læse Kunde/Bil");
		}

		return new Leje(id, kunde, bil, dato, antalDage);
	}
}
