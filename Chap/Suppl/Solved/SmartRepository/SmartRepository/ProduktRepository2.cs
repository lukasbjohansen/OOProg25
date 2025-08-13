
public class ProduktRepository2 : SmartRepository<Produkt>, IProduktRepository
{
	public List<Produkt> HentDyreProdukter()
	{
		return HentHvorDetGælderAt(p => p.Pris > 50);
	}

	public List<Produkt> HentProdukterMedStorLagerværdi()
	{
		return HentHvorDetGælderAt(p => p.Pris * p.AntalPåLager > 3000);
	}

	public List<Produkt> HentProdukterViSnartMangler()
	{
		return HentHvorDetGælderAt(p => p.AntalPåLager <= 40);
	}

	protected override void IndlæsData()
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
			Indsæt(produkt);
		}
	}
}
