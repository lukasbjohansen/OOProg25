
public class ElNet
{
	// Denne List rummer de Apparater, der p.t. er tilsluttet el-nettet.
	private List<Apparat> _apparater;

	public string Beskrivelse { get; }
	public int Kapacitet { get; }

	/// <summary>
	/// Denne property returnerer den samlede "belastning" på el-nettet.
	/// Belastning udregnes som summen af strømforbruget for de apparater,
	/// der er tilsluttet el-nettet.
	/// </summary>
	public int Belastning
	{
		get 
		{
			int belastning = 0;

			// TODO - ikke færdig

			return belastning;
		}
	}

	/// <summary>
	/// Denne property returnerer true hvis el-nettet er "overbelastet",
	/// hvilket defineres som at den samlede belastning er højere end
	/// el-nettets kapacitet. Hvis ikke, returneres false.
	/// </summary>
	public bool Overbelastet
	{
		get 
		{
			return true; // TODO - ikke færdig
		}
	}

	public ElNet(string beskrivelse, int kapacitet)
	{
		Beskrivelse = beskrivelse;
		Kapacitet = kapacitet;

		_apparater = new List<Apparat>();
	}

	/// <summary>
	/// Denne metode tilslutter det givne apparat til el-nettet.
	/// </summary>
	public void Tilslut(Apparat apparat)
	{
		Console.WriteLine($"Tilslutter {apparat.Navn}...");

		// TODO - ikke færdig
	}

	/// <summary>
	/// Denne metode udskriver alle de apparater, der er tilsluttet
	/// til el-nettet. NB: Bemærk, at denne metode således tjener et 
	/// andet formål end ToString (se denne)
	/// </summary>
	public void Udskriv()
	{
		Console.WriteLine();
		Console.WriteLine("Alle tilsluttede apparater:");
		Console.WriteLine("---------------------------");

		// TODO - ikke færdig

		Console.WriteLine();
	}

	/// <summary>
	/// Returnerer en string som giver et "sammendrag" af el-nettets tilstand.
	/// </summary>
	public override string ToString()
	{
		return $"{Beskrivelse}-elnettet har en kapacitet på {Kapacitet} Watt,\n" +
			   $"og er p.t. belastet med {Belastning} Watt ({_apparater.Count} apparater tilsluttet)\n" +
			   $"Elnettet er overbelastet : {BoolToJaNej(Overbelastet)}";
	}

	private string BoolToJaNej(bool trueFalse)
	{
		return trueFalse ? "Ja" : "Nej";
	}
}
