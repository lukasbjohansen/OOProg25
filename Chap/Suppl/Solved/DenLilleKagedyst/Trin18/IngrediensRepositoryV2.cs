
/// <summary>
/// Denne klasse har til formål at hold styr på en samling af 
/// Ingrediens-objekter.
/// </summary>
public class IngrediensRepositoryV2
{
	private Dictionary<string, Ingrediens> _ingredienser;

	public IngrediensRepositoryV2()
	{
		_ingredienser = new Dictionary<string, Ingrediens>();
	}

	public List<Ingrediens> Alle
	{
		get { return _ingredienser.Values.ToList(); }
	}

	/// <summary>
	/// Denne metode tilføjer den givne Ingrediens til _ingredienser.
	/// EKSTRA: men KUN hvis der IKKE i forvejen findes en Ingrediens i 
	/// _ingredienser med samme Navn som den givne Ingrediens.
	/// </summary>
	public void Tilføj(Ingrediens ing)
	{
		if (Find(ing.Navn) == null) // Der findes IKKE en Ingrediens med samme navn
		{
			_ingredienser.Add(ing.Navn, ing);
		}
	}

	/// <summary>
	/// Denne metode returnerer det Ingrediens-objekt i _ingredienser
	/// hvis Navn er lig med det givne navn. Hvis der IKKE findes sådan
	/// et objekt, returnerer metoden null.
	/// </summary>
	public Ingrediens? Find(string navn)
	{
		if (_ingredienser.ContainsKey(navn))
		{
			return _ingredienser[navn];
		}
		else
		{
			return null;
		}
	}

	/// <summary>
	/// Denne metode udskriver alle Ingrediens-objekterne i _ingredienser
	/// på skærmen.
	/// </summary>
	public void Udskriv()
	{
		Console.WriteLine();
		Console.WriteLine("--- Alle ingredienser i Repository");

		foreach (Ingrediens ing in _ingredienser.Values)
		{
			Console.WriteLine(ing);
		}
		Console.WriteLine();
	}
}
