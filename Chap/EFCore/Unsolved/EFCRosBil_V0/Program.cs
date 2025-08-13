using EFCRosBil;

// 1) Opret et context-objekt

using RosBilDBContext context = new RosBilDBContext();


// Læs alle Kunder fra databasen, og udskriv dem (bør udskrive 5 kunder)
foreach (var obj in context.Kunder)
{
	Console.WriteLine(obj);
}

Console.WriteLine();


// Læs alle Kunder fra databasen, og udskriv dem (bør udskrive 5 kunder)
foreach (var obj in context.Set<Kunde>())
{
	Console.WriteLine(obj);
}

Console.WriteLine();

