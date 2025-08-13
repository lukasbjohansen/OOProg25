
public class BilRepository : ADORepositoryBase<Bil>
{
	public BilRepository(string connectionString)
		: base(new DBMethodsBil(connectionString))
	{
	}
}
