
namespace EFCRosBil;

public partial class Kunde : IHarId
{
	public override string ToString()
	{
		return $"[Kunde {Id}] {Navn} (tlf: {Telefon}), er {(Vip ? "" : "ikke ")}VIP ";
	}

	public static Kunde Create(string navn, int telefon, bool vip)
	{
		return new Kunde { Navn = navn, Telefon = telefon, Vip = vip };
	}
}

public partial class Bil : IHarId
{
	public override string ToString()
	{
		return $"[Bil {Id}] {Nummerplade} ({Model}), koster {PrisPrDag} kr./dag (antal udlejninger {Lejes.Count})";
	}

	public static Bil Create(string nummerplade, string model, int prisPrDag)
	{
		return new Bil { Nummerplade = nummerplade, Model = model, PrisPrDag = prisPrDag };
	}
}

public partial class Leje : IHarId
{
	public override string ToString()
	{
		return $"[Leje {Id}] {Kunde.Navn} har lejet {Bil.Nummerplade} fra {Dato}, i {AntalDage} dage";
	}

	public static Leje Create(int kundeId, int bilId, DateOnly dato, int antalDage)
	{
		return new Leje { KundeId = kundeId, BilId = bilId, Dato = dato, AntalDage = antalDage };
	}
}