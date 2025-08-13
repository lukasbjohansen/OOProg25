
/// <summary>
/// Denne klasse modellere hele data-modellen for butikken, dvs. alle 
/// kunder, produkter og ordrer er opbevaret her.
/// </summary>
public class DataModel
{
	public List<Kunde> Kunder { get; }
	public List<Produkt> Produkter { get; }
	public List<Ordre> Ordrer { get; }

	/// <summary>
	///  Returnerer den samlede værdi af lagebeholdningen af produkterne.
	/// </summary>
	public double SamletVærdiAfLager
	{
		get 
		{
			return Produkter.Select(p => p.AntalPåLager * p.Pris).Sum();
		}
	}

	/// <summary>
	///  Returnerer den samlede værdi af ordrerne.
	/// </summary>
	public double SamletVærdiAfOrdrer
	{
		get
		{
			return Ordrer.Select(o => o.TotalPris).Sum();
		}
	}

	/// <summary>
	/// Returnerer den samlede ordrebog, fordelt på produkter.
	/// Hvert element skal forstås således:
	///   Key: Id for produktet
	///   Value: Totalt antal af dette produkt
	/// Eksempel: <2,12> = 12 stk. af Produkt med Id 2.
	/// </summary>
	public Dictionary<int, int> SamletOrdrebog
	{
		get
		{
			return Produkter
				.Select(p => new { p.Id, Total = Ordrer.Select(o => o.AntalAfProdukt(p.Id)).Sum()})
				.ToDictionary(p => p.Id, p => p.Total);
		}
	}


	/// <summary>
	/// Returnerer hvorvidt den nuværende lagerbeholdning 
	/// kan dække den nuværende ordrebog.
	/// </summary>
	public bool ErOrdrerDækketAfLagerbeholdning
	{
		get 
		{
			return SamletOrdrebog.Select(kvp => FindProdukt(kvp.Key).AntalPåLager >= kvp.Value).Where(p => p == false).Count() == 0;
		}
	}

	public DataModel()
	{
		Kunder = new List<Kunde>();
		Produkter = new List<Produkt>();
		Ordrer = new List<Ordre>();

		IndlæsData();
	}

	/// <summary>
	/// Find kunde svarende til det givne Id.
	/// </summary>
	public Kunde FindKunde(int id)
	{
		Kunde? kunde = Kunder.FirstOrDefault(k => k.Id == id);

		if (kunde == null)
			throw new ArgumentException();

		return kunde;
	}

	/// <summary>
	/// Find produkt svarende til det givne Id.
	/// </summary>
	public Produkt FindProdukt(int id)
	{
		Produkt? produkt = Produkter.FirstOrDefault(p => p.Id == id);

		if (produkt == null)
			throw new ArgumentException();

		return produkt;
	}

	/// <summary>
	/// Returnerer en liste med navne på de produkter, hvor der p.t. er færre
	/// på lager end den angivne antal.
	/// </summary>
	public List<string> MangelListe(int antal)
	{
		return Produkter.Where(p => p.AntalPåLager <= antal).Select(p => p.ToString()).ToList();
	}

	private void IndlæsData()
	{
		Kunder.Add(new Kunde(1, "Anne", "anne@mail.dk"));
		Kunder.Add(new Kunde(2, "Bent", "bent@mail.dk"));
		Kunder.Add(new Kunde(3, "Carl", "carl@mail.dk"));

		Produkter.Add(new Produkt(1, "PC", 6000, 12));
		Produkter.Add(new Produkt(2, "Monitor", 2600, 32));
		Produkter.Add(new Produkt(3, "Keyboard", 800, 9));
		Produkter.Add(new Produkt(4, "Mus", 450, 40));

		Ordre o1 = new Ordre(1, FindKunde(1) , this);
		o1.TilføjProdukt(1, 3);
		o1.TilføjProdukt(2, 4);

		Ordre o2 = new Ordre(2, FindKunde(3), this);
		o2.TilføjProdukt(3, 6);
		o2.TilføjProdukt(2, 1);

		Ordre o3 = new Ordre(3, FindKunde(3), this);
		o3.TilføjProdukt(1, 1);
		o3.TilføjProdukt(4, 5);

		Ordre o4 = new Ordre(4, FindKunde(2), this);
		o4.TilføjProdukt(2, 1);
		o4.TilføjProdukt(3, 2);
		o4.TilføjProdukt(4, 6);

		Ordre o5 = new Ordre(5, FindKunde(1), this);
		o5.TilføjProdukt(1, 2);
		o5.TilføjProdukt(2, 3);
		o5.TilføjProdukt(3, 4);
		o5.TilføjProdukt(4, 2);

		Ordrer.Add(o1);
		Ordrer.Add(o2);
		Ordrer.Add(o3);
		Ordrer.Add(o4);
		Ordrer.Add(o5);
	}

	public override string ToString()
	{
		string str = "Overblik over virksomheden: \n";

		str += $"Total værdi af lager : {SamletVærdiAfLager} kr.\n";
		str += $"Total værdi af ordrer : {SamletVærdiAfOrdrer} kr.\n";
		str += $"Er alle ordrer dækket af lager? {(ErOrdrerDækketAfLagerbeholdning ? "Ja" : "Nej")}\n";

		return str;
	}
}
