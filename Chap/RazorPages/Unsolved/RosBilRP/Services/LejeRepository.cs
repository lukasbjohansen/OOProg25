using Microsoft.EntityFrameworkCore;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class LejeRepository : EFCRepositoryBase<Leje, RosBilDBContext>, ILejeRepository
{
	protected override IQueryable<Leje> GetAllWithIncludes(DbContext context)
	{
		return base.GetAllWithIncludes(context)
			.Include(l => l.Kunde)
			.Include(l => l.Bil);
	}
}
