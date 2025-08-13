
public class Test
{
	public void Kør()
	{
		// 1) Opret nogle Ingrediens-objekter, og udskriv dem efterfølgende

		Ingrediens i1 = new Ingrediens("Mel", "Kg", 20);
		Ingrediens i2 = new Ingrediens("Sukker", "Kg", 35);
		Ingrediens i3 = new Ingrediens("Æg", "Stk", 4);
		Ingrediens i4 = new Ingrediens("Vand", "Dl", 0);

		Console.WriteLine();
		Console.WriteLine(i1);
		Console.WriteLine(i2);
		Console.WriteLine(i3);
		Console.WriteLine(i4);
		Console.WriteLine();


		// 2) Opret et IngrediensRepository-objekt

		IngrediensRepository repo = new IngrediensRepository();


		// 3) Indsæt Ingrediens-objekterne i IngrediensRepository

		repo.Tilføj(i1);
		repo.Tilføj(i2);
		repo.Tilføj(i3);
		repo.Tilføj(i4);


		// 4) Udskriv indholdet af IngrediensRepository

		repo.Udskriv();


		// 5) Slå nogle Ingredienser op i IngrediensRepository

		Ingrediens? iA = repo.Find("Mel");
		Ingrediens? iB = repo.Find("Salt");
		Ingrediens? iC = repo.Find("Sukker");

		Console.WriteLine();
		UdskrivFundetIngrediens("Mel", iA);
		UdskrivFundetIngrediens("Salt", iB);
		UdskrivFundetIngrediens("Sukker", iC);
		Console.WriteLine();


		// 6) Opret et Lager-objekt

		Lager mitLager = new Lager();


		// 7) Tilføj nogle ingrediens-antal til lageret

		mitLager.Tilføj("Sukker", 2.5);
		mitLager.Tilføj("Mel", 2.5);
		mitLager.Tilføj("Vand", 1000);
		mitLager.Tilføj("Salt", 20);
		mitLager.Tilføj("Mel", 1.2);
		mitLager.Tilføj("Æg", 2);


		// 8) Udskriv indholdet af lageret

		mitLager.Udskriv();


		// 9) Slå nogle Ingrediens-antal op i lageret

		double hvorMegetMel = mitLager.FindAntal("Mel");
		double hvorMegetSalt = mitLager.FindAntal("Salt");
		double hvorMegetPeber = mitLager.FindAntal("Peber");
		double hvorMegetSukker = mitLager.FindAntal("Sukker");

		Console.WriteLine();
		UdskrivFundetAntal("Mel", hvorMegetMel);
		UdskrivFundetAntal("Salt", hvorMegetSalt);
		UdskrivFundetAntal("Peber", hvorMegetPeber);
		UdskrivFundetAntal("Sukker", hvorMegetSukker);
		Console.WriteLine();


		// 10) Opret et par Opskrift-objekter

		Opskrift lagkage = new Opskrift("Lagkage");
		Opskrift sandkage = new Opskrift("Sandkage");


		// 11) Tilføj nogle ingrediens-antal til opskrifterne

		lagkage.Tilføj("Mel", 0.4);
		lagkage.Tilføj("Vand", 3);
		lagkage.Tilføj("Sukker", 0.3);
		lagkage.Tilføj("Æg", 4);

		sandkage.Tilføj("Mel", 0.2);
		sandkage.Tilføj("Vand", 2);
		sandkage.Tilføj("Sukker", 0.1);


		// 12) Udskriv opskrifterne

		lagkage.Udskriv();
		sandkage.Udskriv();


		// 13) Opret et OpskriftLogik-objekt

		OpskriftLogik logik = new OpskriftLogik();


		// 14) Find prisen på hver opskrift

		double prisPåLagkage = logik.PrisPåOpskrift(repo, lagkage);
		double prisPåSandkage = logik.PrisPåOpskrift(repo, sandkage);

		Console.WriteLine();
		Console.WriteLine($"Lagkage koster {prisPåLagkage} kr.");
		Console.WriteLine($"Sandkage koster {prisPåSandkage} kr.");
		Console.WriteLine();


		// 15) Afgør, om kagen kan laves ud fra hvad vi har på lager

		Console.WriteLine();
		Console.WriteLine($"Kan vi lave Lagkage : {BoolToJaNej(logik.KanDenLaves(repo, mitLager, lagkage))}");
		Console.WriteLine($"Kan vi lave Sandkage : {BoolToJaNej(logik.KanDenLaves(repo, mitLager, sandkage))}");
		Console.WriteLine();


		// Trin 18)
		Console.WriteLine();
		Console.WriteLine($"Hvor mange Lagkage : {logik.HvorMangeKanLaves(repo, mitLager, lagkage)}");
		Console.WriteLine($"Hvor mange Sandkage : {logik.HvorMangeKanLaves(repo, mitLager, sandkage)}");
		Console.WriteLine();

		Dictionary<string, double> manglerLagkage = logik.HvadManglerVi(repo, mitLager, lagkage);

		Console.WriteLine("Hvad mangler vi til Lagkage:");
		foreach (var kvp in manglerLagkage)
		{
			Console.WriteLine(kvp);
		}
	}


	#region Hjælpe-metoder

	private void UdskrivFundetIngrediens(string navn, Ingrediens? ing)
	{
		if (ing == null)
		{
			Console.WriteLine($"Fandt ikke nogen ingrediens med navnet {navn}");
		}
		else
		{
			Console.WriteLine($"Fandt denne ingrediens med navnet {navn} : {ing}");
		}
	}

	private void UdskrivFundetAntal(string navn, double antal)
	{
		Console.WriteLine($"Fandt {antal} {navn}.");
	}

	private string BoolToJaNej(bool trueFalse)
	{
		return trueFalse ? "Ja" : "Nej";
	} 

	#endregion
}
