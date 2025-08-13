
/// <summary>
/// Denne klasse repræsenterer en "ingrediens", dvs. noget som indgår
/// i en opskrift. Det kunne være sukker, æg, mel o.s.v..
/// </summary>
public class Ingrediens
{
	public string Navn { get; }
	public string Enhed { get; }
	public double PrisPrEnhed { get; set; }

	public Ingrediens(string navn, string enhed, double prisPrEnhed)
	{
		Navn = navn;
		Enhed = enhed;
		PrisPrEnhed = prisPrEnhed;
	}

	public override string ToString() // Givet
	{
		return $"{Navn}, koster {PrisPrEnhed} kr. pr. {Enhed}";
	}
}
