
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

public class LejeRepository : EFCRepositoryBase<Leje>
{
	protected override DbContext CreateDbContext()
	{
		return new RosBilDBContext();
	}

	protected override IQueryable<Leje> GetAllWithIncludes(DbContext context)
	{
		return base.GetAllWithIncludes(context)
			.Include(l => l.Kunde)
			.Include(l => l.Bil);
	}
}
