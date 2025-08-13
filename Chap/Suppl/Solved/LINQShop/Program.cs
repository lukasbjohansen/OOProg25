
DataModel dataModel = new DataModel();

foreach (Produkt produkt in dataModel.Produkter)
{
	Console.WriteLine(produkt);
}

foreach (Ordre ordre in dataModel.Ordrer)
{
	Console.WriteLine(ordre);
}

Console.WriteLine(dataModel.SamletVærdiAfLager);
Console.WriteLine(dataModel.SamletVærdiAfOrdrer);
Console.WriteLine(dataModel.ErOrdrerDækketAfLagerbeholdning);

foreach (var kvp in dataModel.SamletOrdrebog)
{
	Console.WriteLine(kvp);
}
Console.WriteLine();

Console.WriteLine(dataModel);