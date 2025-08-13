
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

public class KundeRepository : EFCRepositoryBase<Kunde>
{
	protected override DbContext CreateDbContext()
	{
		return new RosBilDBContext();
	}
}
