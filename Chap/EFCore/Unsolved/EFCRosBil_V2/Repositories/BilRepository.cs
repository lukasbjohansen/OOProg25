
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

public class BilRepository : EFCRepositoryBase<Bil>
{
	protected override DbContext CreateDbContext()
	{
		return new RosBilDBContext();
	}
}
