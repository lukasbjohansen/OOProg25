
public class Apparat
{
	public string Navn { get; }
	public int StrømForbrug { get; }
	public bool Tændt { get; set; }

	public Apparat(string navn, int strømForbrug)
	{
		Navn = navn;
		StrømForbrug = strømForbrug;
		Tændt = true;
	}

	public override string ToString()
	{
		return $"{Navn}, bruger {StrømForbrug} Watt (Tændt = {Tændt})";
	}
}
