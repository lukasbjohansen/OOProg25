
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

public class LejeRepository : EFCRepositoryAppBase<Leje>
{
	protected override IQueryable<Leje> GetAllWithIncludes(DbContext context)
	{
		return context.Set<Leje>().Include(l => l.Kunde).Include(l => l.Bil);
	}
}
