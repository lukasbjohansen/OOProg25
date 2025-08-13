
public class Kunde
{
	public int Id { get; }
	public string Navn { get; }
	public string EMail { get; }

	public Kunde(int id, string navn, string eMail)
	{
		Id = id;
		Navn = navn;
		EMail = eMail;
	}

	public override string? ToString()
	{
		return $"[Kunde {Id}] {Navn}, {EMail}";
	}
}
