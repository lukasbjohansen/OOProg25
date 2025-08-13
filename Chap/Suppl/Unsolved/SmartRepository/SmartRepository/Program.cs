
IProduktRepository produktRepo = new ProduktRepository();
// IProduktRepository produktRepo = new ProduktRepository2();

UdskrivProdukter("Alle Produkter", produktRepo.HentAlle());

Console.WriteLine("HentDyreProdukter bør returnere Produkt-objekterne med Id = [1, 5, 6, 7]");
UdskrivProdukter("Dyre Produkter", produktRepo.HentDyreProdukter());

Console.WriteLine("HentProdukterViSnartMangler bør returnere Produkt-objekterne med Id = [4, 5, 6]");
UdskrivProdukter("Produkter Vi Snart Mangler", produktRepo.HentProdukterViSnartMangler());

Console.WriteLine("HentProdukterMedStorLagerværdi bør returnere Produkt-objekterne med Id = [1, 2, 7]");
UdskrivProdukter("Produkter Med Stor Lagerværdi", produktRepo.HentProdukterMedStorLagerværdi());


void UdskrivProdukter(string overskrift, List<Produkt> produkter)
{
	Console.WriteLine($"{overskrift}  ({produkter.Count} produkter)");

	foreach (Produkt produkt in produkter)
	{
		Console.WriteLine(produkt);
	}

	Console.WriteLine();
}
