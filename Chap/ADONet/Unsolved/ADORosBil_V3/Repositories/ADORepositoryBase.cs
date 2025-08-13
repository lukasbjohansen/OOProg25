
/// <summary>
/// Base-klasse for en ADO-baseret implementation af IRepository interfacet,
/// ved hjælp af DBMethods-klasserne.
/// </summary>
public class ADORepositoryBase<T> : IRepository<T> where T : IHarId
{
    private DBMethodsBase<T> _dbMethods;

    public ADORepositoryBase(DBMethodsBase<T> dbMethods)
    {
        _dbMethods = dbMethods;
    }

	public List<T> All
	{
		get { return _dbMethods.ReadAllFromDB(); }
	}

	public int Create(T t)
    {
        int id = NextId();
        t.Id = id;

        _dbMethods.WriteToDB(t);
        return id;
    }

    public bool Delete(int id)
    {
        return _dbMethods.DeleteFromDB(id) > 0;
    }

    public T? Read(int id)
    {
        return _dbMethods.ReadFromDB(id);
    }

    private int NextId()
    {
        return All.Select(t => t.Id).DefaultIfEmpty(0).Max() + 1;
    }
}
