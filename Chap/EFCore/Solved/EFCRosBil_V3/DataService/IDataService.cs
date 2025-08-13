using EFCRosBil;

public interface IDataService
{
	IRepository<Bil> Biler { get; }
	IRepository<Kunde> Kunder { get; }
	IRepository<Leje> Udlejninger { get; }
}