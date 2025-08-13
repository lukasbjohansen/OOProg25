
public class Produkt
{
	public int Id { get; }
	public string Beskrivelse { get; }
	public double Pris { get; }
	public int AntalPåLager { get; set; }

	public Produkt(int id, string beskrivelse, double pris, int antalPåLager)
	{
		Id = id;
		Beskrivelse = beskrivelse;
		Pris = pris;
		AntalPåLager = antalPåLager;
	}

	public override string ToString()
	{
		return $"[{Id}] {Beskrivelse}, koster {Pris} kr./stk. ({AntalPåLager} stk på lager)";
	}
}
