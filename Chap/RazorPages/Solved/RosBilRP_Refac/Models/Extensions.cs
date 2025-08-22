
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RosBilRP.Models;

// Denne fil rummer "extensions" til de auto-genererede domæne-klasser.
// Typisk vil vi gerne tilføje følgende:
// 1) Klassen implementerer IHarId, hvilket gør den kompatibel med Repository-klasserne.
// 2) En ToString-metode. (NB: Strengt taget ikke vigtig i RP-app)
// 3) En statisk Construct-metode, som gør det lidt lettere at konstruere nye objekter uden
//    brug af en konventionel constructor (som kan give problemer med Entity Framework).
//    (NB: Strengt taget ikke vigtig i RP-app)

public partial class Kunde : IHarId
{
	public override string ToString()
	{
		return $"[Kunde {Id}] {Navn} (tlf: {Telefon}), er {(Vip ? "" : "ikke ")}VIP ";
	}

	public static Kunde Construct(string navn, int telefon, bool vip)
	{
		return new Kunde { Navn = navn, Telefon = telefon, Vip = vip };
	}
}

public partial class Bil : IHarId
{
	[NotMapped]
	public string NummerpladeOgModel { get { return $"{Nummerplade} ({Model})"; } }

	public override string ToString()
	{
		return $"[Bil {Id}] {Nummerplade} ({Model}), koster {PrisPrDag} kr./dag (antal udlejninger {Lejes.Count})";
	}

	public static Bil Construct(string nummerplade, string model, int prisPrDag)
	{
		return new Bil { Nummerplade = nummerplade, Model = model, PrisPrDag = prisPrDag };
	}
}

public partial class Leje : IHarId
{
	public override string ToString()
	{
		return $"[Leje {Id}] {Kunde?.Navn} har lejet {Bil?.Nummerplade} fra {Dato}, i {AntalDage} dage";
	}

	// [NotMapped]
	public string Beskrivelse { get { return $"{Kunde?.Navn} ({Bil?.Nummerplade})  {Dato}" ; } }

	[NotMapped]
	public List<Opgave> OpgaverIGang { get { return Opgaves.Where(opg => !opg.Afsluttet).ToList(); } }

	public static Leje Construct(int kundeId, int bilId, DateOnly dato, int antalDage)
	{
		return new Leje { KundeId = kundeId, BilId = bilId, Dato = dato, AntalDage = antalDage };
	}
}

public partial class Ansat : IHarId
{
}

public partial class Opgave : IHarId
{
	public override string ToString()
	{
		return $"{Ansat?.Navn} ({Beskrivelse})";
	}
}

