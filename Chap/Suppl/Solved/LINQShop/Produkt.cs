
public class Produkt
{
	public int Id { get; }
	public string Beskrivelse { get; }
	public double Pris { get; set; }
	public int AntalPåLager { get; set; }

	public Produkt(int id, string beskrivelse, double pris, int antalPåLager)
	{
		Id = id;
		Beskrivelse = beskrivelse;
		Pris = pris;
		AntalPåLager = antalPåLager;
	}

	public override string? ToString()
	{
		return $"[Produkt {Id}] {Beskrivelse}, {Pris} kr.  ({AntalPåLager} stk. på lager)";
	}
}
