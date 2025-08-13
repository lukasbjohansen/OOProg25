
using EFCRosBil;

/// <summary>
/// Denne klasse giver en samlet adgang til alle repositories, 
/// og dermed til alle data i databasen.
/// </summary>
public class DataService
{
	public IRepository<Kunde> Kunder { get; }
	public IRepository<Bil> Biler { get; }
	public IRepository<Leje> Udlejninger { get; }

	public DataService()
	{
		// Map repository-interfaces til konkrete implementationer
		Kunder = new KundeRepository();
		Biler = new BilRepository();
		Udlejninger = new LejeRepository();
	}
}
