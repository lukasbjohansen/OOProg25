
public class Ordre
{
	/// <summary>
	/// Bemæk, at man via dette instance field kan tilgå 
	/// data-modellen fra det enkelte Ordre-objekt.
	/// </summary>
	private DataModel _dataModel;

	public int Id { get; }
	public Kunde Kunden { get; }

	/// <summary>
	/// Denne property rummer de produkter, som indgår i ordren.
	/// Hvert element skal forstås således:
	///   Key: Id for produktet
	///   Value: Antal af dette produkt
	/// Eksempel: <1,4> = 4 stk. af Produkt med Id 1.
	/// </summary>
	public Dictionary<int, int> AntalProdukter { get; }

	/// <summary>
	/// Returnerer den totale pris på ordren.
	/// </summary>
	public double TotalPris
	{
		get 
		{
			return AntalProdukter.Select(kvp => _dataModel.FindProdukt(kvp.Key).Pris * kvp.Value).Sum();
		}
	}

	public Ordre(int id, Kunde kunden, DataModel dataModel)
	{
		Id = id;
		Kunden = kunden;
		AntalProdukter = new Dictionary<int, int>();

		_dataModel = dataModel;
	}

	/// <summary>
	/// Tilføj et antal af det angivne produkt.
	/// </summary>
	public void TilføjProdukt(int produktId, int antal)
	{
		if (AntalProdukter.ContainsKey(produktId))
		{
			AntalProdukter[produktId] += antal;
		}
		else
		{
			AntalProdukter[produktId] = antal;
		}
	}

	/// <summary>
	/// Returnerer hvor mange af det givne produkt der er i ordren.
	/// </summary>
	public int AntalAfProdukt(int produktId)
	{
		return AntalProdukter.ContainsKey(produktId) ? AntalProdukter[produktId] : 0;
	}

	public override string ToString()
	{
		string str = $"[Ordre {Id}] til kunden {Kunden.Navn}. Total pris : {TotalPris} kr.\n";
		str += "----------------------------------------------\n";

		foreach (var kvp in AntalProdukter)
		{
			Produkt p = _dataModel.FindProdukt(kvp.Key);
			int antal = kvp.Value;

			str += $"{antal} stk. {p.Beskrivelse}  :  {p.Pris * antal} kr. \n";
		}

		return str;
	}
}
