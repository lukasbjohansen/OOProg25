
public class LejeRepository : ADORepositoryBase<Leje>
{
	public LejeRepository(string connectionString)
		: base(new DBMethodsLejeJoin(connectionString))
	{
	}
}
