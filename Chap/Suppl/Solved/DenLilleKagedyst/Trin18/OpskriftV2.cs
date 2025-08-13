
public class OpskriftV2 : IngAntal
{
	public string Navn { get; }

	public OpskriftV2(string navn)
	{
		Navn = navn;
	}

	public double Pris(IngrediensRepository repo)
	{
		double pris = 0;

		foreach (var kvp in _ingAntal)
		{
			string ingNavn = kvp.Key;
			double antalDerKræves = kvp.Value;
			double PrisPrEnhed = repo.Find(ingNavn)?.PrisPrEnhed ?? 0; // Burde nok give en Exception

			pris = pris + (antalDerKræves * PrisPrEnhed);
		}

		return pris;
	}

	public bool KanDenLaves(IngrediensRepository repo, Lager lager)
	{
		foreach (var kvp in _ingAntal)
		{
			string ingNavn = kvp.Key;
			double antalDerKræves = kvp.Value;
			double antalDerHaves = lager.FindAntal(ingNavn);

			if (antalDerKræves > antalDerHaves)
			{
				return false;
			}
		}

		return true;
	}

	public int HvorMangeKanLaves(IngrediensRepository repo, Lager lager)
	{
		double hvorMange = double.MaxValue;

		foreach (var kvp in _ingAntal)
		{
			string ingNavn = kvp.Key;
			double antalDerKræves = kvp.Value;
			double antalDerHaves = lager.FindAntal(ingNavn);

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

	public Dictionary<string, double> HvadManglerVi(IngrediensRepository repo, Lager lager)
	{
		Dictionary<string, double> mangler = new Dictionary<string, double>();

		if (KanDenLaves(repo, lager)) // Vi mangler ikke noget
		{
			return mangler;
		}

		foreach (var kvp in _ingAntal)
		{
			string ingNavn = kvp.Key;
			double antalDerKræves = kvp.Value;
			double antalDerHaves = lager.FindAntal(ingNavn);

			double antalDerMangler = antalDerKræves - antalDerHaves;

			if (antalDerMangler > 0)
			{
				mangler.Add(ingNavn, antalDerMangler);
			}
		}

		return mangler;
	}

	protected override void UdskrivHeader()
	{
		Console.WriteLine();
		Console.WriteLine($"--- Alle ingredienser i opskriften på {Navn}");
	}
}
