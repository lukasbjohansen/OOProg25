
using EFCRosBil;

public class MockDataService : IDataService
{
	public IRepository<Kunde> Kunder { get; }
	public IRepository<Bil> Biler { get; }
	public IRepository<Leje> Udlejninger { get; }

	public MockDataService()
	{
		// Map repository-interfaces til konkrete implementationer
		Kunder = new MockKundeRepo();
		Biler = new MockBilRepo();
		Udlejninger = new MockLejeRepo();
	}
}
