
public class KundeRepository : ADORepositoryBase<Kunde>
{
	public KundeRepository(string connectionString) 
		: base(new DBMethodsKunde(connectionString))
	{
	}
}
