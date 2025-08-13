
public class ElNet
{
	private List<Apparat> _apparater;

	public string Beskrivelse { get; }
	public int Kapacitet { get; }
	public bool AdvarVedOverbelastning { get; }

	public int CountTændt
	{
		get
		{
			int countTændt = 0;

			foreach (Apparat apparat in _apparater)
			{
				if (apparat.Tændt)
				{
					countTændt++;
				}
			}

			return countTændt;
		}
	}

	public int Belastning
	{
		get 
		{
			int belastning = 0;

			foreach (Apparat apparat in _apparater)
			{
				if (apparat.Tændt)
				{
					belastning += apparat.StrømForbrug;
				}
			}

			return belastning;
		}
	}

	public bool Overbelastet
	{
		get { return Belastning > Kapacitet; }
	}

	public ElNet(string beskrivelse, int kapacitet, bool advar)
	{
		Beskrivelse = beskrivelse;
		Kapacitet = kapacitet;

		AdvarVedOverbelastning = advar;

		_apparater = new List<Apparat>();
	}

	public void Tilslut(Apparat apparat)
	{
		Console.WriteLine($"Tilslutter {apparat.Navn}...");

		if (AdvarVedOverbelastning && VilOverbelaste(apparat))
		{
			Console.WriteLine($"Tilsluttede ikke {apparat.Navn}, da det vil overbelaste el-nettet");
		}
		else
		{
			_apparater.Add(apparat);
		}
	}

	public bool VilOverbelaste(Apparat apparat)
	{
		return apparat.StrømForbrug + Belastning > Kapacitet;
	}

	public void TændEllerSluk(string navn, bool tændSluk)
	{
		Apparat? apparat = Find(navn);

		if (apparat != null)
		{
			apparat.Tændt = tændSluk;
		}
	}

	private Apparat? Find(string navn)
	{
		foreach (Apparat apparat in _apparater)
		{
			if (apparat.Navn == navn)
			{
				return apparat;
			}
		}

		return null;
	}

	public void Udskriv()
	{
		Console.WriteLine();
		Console.WriteLine("Alle tilsluttede apparater:");
		Console.WriteLine("---------------------------");

		foreach (Apparat apparat in _apparater)
		{
			Console.WriteLine(apparat);
		}
		Console.WriteLine();
	}

	public override string ToString()
	{
		return $"{Beskrivelse}-elnettet har en kapacitet på {Kapacitet} Watt,\n" +
			   $"og er p.t. belastet med {Belastning} Watt ({_apparater.Count} apparater tilsluttet, {CountTændt} tændt)\n" +
			   $"Elnettet er overbelastet : {BoolToJaNej(Overbelastet)}";
	}

	private string BoolToJaNej(bool trueFalse)
	{
		return trueFalse ? "Ja" : "Nej";
	}
}
