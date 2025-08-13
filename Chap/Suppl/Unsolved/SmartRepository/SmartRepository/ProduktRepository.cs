
public class ProduktRepository : IProduktRepository
{
	private List<Produkt> _produkter;

	public ProduktRepository()
	{
		_produkter = new List<Produkt>();

		IndlæsData();
	}

	public List<Produkt> HentAlle()
	{
		return _produkter;
	}

	public List<Produkt> HentDyreProdukter()
	{
		return new List<Produkt>(); // TODO - HentDyreProdukter skal implementeres korrekt
	}

	public List<Produkt> HentProdukterViSnartMangler()
	{
		return new List<Produkt>(); // TODO - HentProdukterViSnartMangler skal implementeres korrekt
	}

	public List<Produkt> HentProdukterMedStorLagerværdi()
	{
		return new List<Produkt>(); // TODO - HentProdukterMedStorLagerværdi skal implementeres korrekt
	}

	private void IndlæsData()
	{
		int id = 1;

		List<Produkt> testProdukter = new List<Produkt>
		{
			new Produkt(id++, "Tallerken", 65, 52),
			new Produkt(id++, "Kniv", 32, 109),
			new Produkt(id++, "Gaffel", 32, 76),
			new Produkt(id++, "Glas", 19, 37),
			new Produkt(id++, "Bordskåner", 80, 32),
			new Produkt(id++, "Dug", 179, 14),
			new Produkt(id++, "Sofapude", 79, 41)
		};

		foreach (Produkt produkt in testProdukter)
		{
			_produkter.Add(produkt);
		}
	}
}
