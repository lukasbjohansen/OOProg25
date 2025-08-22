namespace RosBilRP.Models;

public class Kunde : IHarId
{
	public int Id { get; set; }
	public string Navn { get; set; }
	public int Telefon { get; set; }
	public bool VIP { get; set; }

	public Kunde()
	{
	}

	public Kunde(int id, string navn, int telefon, bool vip)
	{
		Id = id;
		Navn = navn;
		Telefon = telefon;
		VIP = vip;
	}

	public override string ToString()
	{
		return $"[Kunde {Id}] {Navn} (tlf: {Telefon}), er {(VIP ? "" : "ikke ")}VIP ";
	}
}
