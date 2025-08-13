
/// <summary>
/// Denne klasse repræsenterer det "lager" af ingredienser vi råder over.
/// Vi benytter navnet på en ingrediens som NØGLE, og mængden af ingrediensen
/// som VÆRDI. Det kan f.eks. være "Sukker" -> 2.5, eller "Æg" -> 6.
/// </summary>
public class Lager
{
	private Dictionary<string, double> _antalPåLager;

	public Lager()
	{
		_antalPåLager = new Dictionary<string, double>();
	}

	/// <summary>
	/// Denne metode tilføjer det givne antal af den givne ingrediens
	/// til vores lager. 
	/// NB: Bemærk, at hvis den angivne ingrediens allerede findes på
	/// lageret, skal det angivne antal lægges til det antal der allerede findes.
	/// </summary>
	public void Tilføj(string navn, double antal)
	{
		if (_antalPåLager.ContainsKey(navn)) // Ingrediens findes allerede på lager.
		{
			_antalPåLager[navn] += antal;
		}
		else
		{
			_antalPåLager.Add(navn, antal);
		}
	}

	/// <summary>
	/// Denne metode returnerer hvor mange enheder vi har på lager af den 
	/// givne ingrediens. Hvis ingrediensen ikke er på lager, returneres 0 (nul).
	/// </summary>
	public double FindAntal(string navn)
	{
		if (_antalPåLager.ContainsKey(navn)) // Ingrediens findes på lager
		{
			return _antalPåLager[navn];

		}
		else
		{
			return 0;
		}
	}

	/// <summary>
	/// Denne metode udskriver en oversigt over alle de ingredienser vi har på lager,
	/// d.v.s. for hver ingrediens udskrives navnet og antallet på lager.
	/// på skærmen.
	/// </summary>
	public void Udskriv()
	{
		Console.WriteLine();
		Console.WriteLine("--- Alle ingredienser på lager");

		foreach (var kvp in _antalPåLager)
		{
			Console.WriteLine(kvp);
		}
		Console.WriteLine();
	}
}
