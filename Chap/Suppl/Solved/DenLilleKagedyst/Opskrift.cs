
/// <summary>
/// Denne klasse repræsenterer en opskrift – f.eks. på en kage – i form af navnet 
/// på den madvare opskriften vedrører, samt de ingredienser – givet med navn og 
/// krævet antal – der skal bruges. 
/// </summary>
public class Opskrift
{
	private Dictionary<string, double> _antalDerKræves;

	public string Navn { get; }

	public Opskrift(string navn)
	{
		Navn = navn;

		_antalDerKræves = new Dictionary<string, double>();
	}

	public void Tilføj(string navn, double antal)
	{
		if (_antalDerKræves.ContainsKey(navn))
		{
			_antalDerKræves[navn] += antal;
		}
		else
		{
			_antalDerKræves.Add(navn, antal);
		}
	}

	public double FindAntal(string navn)
	{
		if (_antalDerKræves.ContainsKey(navn))
		{
			return _antalDerKræves[navn];

		}
		else
		{
			return 0;
		}
	}

	public void Udskriv()
	{
		Console.WriteLine();
		Console.WriteLine($"--- Alle ingredienser i opskriften på {Navn}");
		foreach (var kvp in _antalDerKræves)
		{
			Console.WriteLine(kvp);
		}
		Console.WriteLine();
	}
}
