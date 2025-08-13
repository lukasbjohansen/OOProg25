
/// <summary>
/// Denne klasse rummer forretningslogik relateret til opskrifter.
/// </summary>
public class OpskriftLogik
{
	/// <summary>
	/// Returnerer prisen for den givne opskrift.
	/// </summary>
	public double PrisPåOpskrift(IngrediensRepository repo, Opskrift opskrift)
	{
		double pris = 0;

		foreach (Ingrediens ing in repo.Alle)
		{
			double antal = opskrift.FindAntal(ing.Navn);

			pris = pris + antal * ing.PrisPrEnhed;
		}

		return pris;
	}

	/// <summary>
	/// Returnerer true hvis vi kan opfylde kravene i den givne opskrift,
	/// ud fra indholdet i det givne lager. Hvis ikke, returneres false.
	/// </summary>
	public bool KanDenLaves(IngrediensRepository repo, Lager lager, Opskrift opskrift)
	{
		foreach (Ingrediens ing in repo.Alle)
		{
			double antalDerKræves = opskrift.FindAntal(ing.Navn);
			double antalDerHaves = lager.FindAntal(ing.Navn);

			if (antalDerKræves > antalDerHaves)
			{
				return false;
			}
		}

		return true;
	}

	public int HvorMangeKanLaves(IngrediensRepository repo, Lager lager, Opskrift opskrift)
	{
		double hvorMange = double.MaxValue;

		foreach (Ingrediens ing in repo.Alle)
		{
			double antalDerKræves = opskrift.FindAntal(ing.Navn);
			double antalDerHaves = lager.FindAntal(ing.Navn);

			if (antalDerKræves > 0)
			{
				double hvorMangeMuligt = antalDerHaves / antalDerKræves;
				
				if (hvorMangeMuligt < hvorMange)
				{
					hvorMange = hvorMangeMuligt;
				}
			}
		}

		return Convert.ToInt32(hvorMange);
	}

	public Dictionary<string, double> HvadManglerVi(IngrediensRepository repo, Lager lager, Opskrift opskrift)
	{
		Dictionary<string, double> mangler = new Dictionary<string, double>();

		if (KanDenLaves(repo, lager, opskrift)) // Vi mangler ikke noget
		{
			return mangler;
		}

		foreach (Ingrediens ing in repo.Alle)
		{
			double antalDerKræves = opskrift.FindAntal(ing.Navn);
			double antalDerHaves = lager.FindAntal(ing.Navn);

			double antalDerMangler = antalDerKræves - antalDerHaves;

			if (antalDerMangler > 0)
			{
				mangler.Add(ing.Navn, antalDerMangler);
			}
		}

		return mangler;
	}
}
