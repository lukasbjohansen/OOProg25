
public enum IngrediensNavn
{
	Sukker,
	Mel,
	Æg,
	Vand,
	Salt,
	Peber
} // ... og så videre

public class IngrediensV2
{
	public IngrediensNavn Navn { get; }
	public string Enhed { get; }
	public double PrisPrEnhed { get; set; }

	public IngrediensV2(IngrediensNavn navn, string enhed, double prisPrEnhed)
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
