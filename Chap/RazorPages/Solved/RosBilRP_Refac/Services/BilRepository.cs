using Microsoft.EntityFrameworkCore;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class BilRepository : EFCRepositoryBase<Bil, RosBilDBContext>, IBilRepository
{
	protected override IQueryable<Bil> GetAllWithIncludes(DbContext context)
	{
		return base.GetAllWithIncludes(context)
			.Include(b => b.Lejes);
	}
}
