
/// <summary>
/// Denne klase kunne være en base-klasse for Lager og Opskrift
/// </summary>
public abstract class IngAntal
{
	protected Dictionary<string, double> _ingAntal;

	public IngAntal()
	{
		_ingAntal = new Dictionary<string, double>();
	}

	public void Tilføj(string navn, double antal)
	{
		if (_ingAntal.ContainsKey(navn))
		{
			_ingAntal[navn] += antal;
		}
		else
		{
			_ingAntal.Add(navn, antal);
		}
	}

	public double FindAntal(string navn)
	{
		if (_ingAntal.ContainsKey(navn))
		{
			return _ingAntal[navn];

		}
		else
		{
			return 0;
		}
	}

	public void Udskriv()
	{
		UdskrivHeader();

		foreach (var kvp in _ingAntal)
		{
			Console.WriteLine(kvp);
		}
		Console.WriteLine();
	}

	/// <summary>
	/// Denne metode skal overrides i sub-klasserne.
	/// </summary>
	protected abstract void UdskrivHeader();
}
