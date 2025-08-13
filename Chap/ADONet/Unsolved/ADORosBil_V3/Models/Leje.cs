
public class Leje : IHarId
{
	public int Id { get; set; }
	public Kunde Kunden { get; set; }
	public Bil Bilen { get; }
	public DateOnly Dato { get; }
	public int AntalDage { get; set; }

	public Leje(int id, Kunde kunden, Bil bilen, DateOnly dato, int antalDage)
	{
		Id = id;
		Kunden = kunden;
		Bilen = bilen;
		Dato = dato;
		AntalDage = antalDage;
	}

	public override string ToString()
	{
		return $"[Leje {Id}] {Kunden.Navn} har lejet {Bilen.Nummerplade} fra {Dato}, i {AntalDage} dage";
	}
}
