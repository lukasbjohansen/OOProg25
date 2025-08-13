
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

	/// <summary>
	/// Denne metode er en lidt Factory-agtig metode, som hjælper med at opbygge
	/// et Leje-objekt ud fra de data der er læst fra en række i Leje-tabellen.
	/// Da Leje-rækken jo refererer til Kunde og Bil via Id'er (fremmednøgler),
	/// er der brug for at komme fra f.eks. et Kunde-id til et Kunde-objekt.
	/// Det kan DBMethodsKunde jo hjælpe os med (og tilsvarende DBMethodsBil)
	/// </summary>
	public static Leje CreateLeje(int id, int kundeId, int bilId, DateOnly dato, int antalDage, DBMethodsKunde dbmKunde, DBMethodsBil dbmBil)
	{
		Kunde? kunde = dbmKunde.ReadFromDB(kundeId);
		Bil? bil = dbmBil.ReadFromDB(bilId);

		if (kunde == null || bil == null)
		{
			throw new Exception("Kunne ikke læse Kunde/Bil");
		}

		return new Leje(id, kunde, bil, dato, antalDage);
	}
}
