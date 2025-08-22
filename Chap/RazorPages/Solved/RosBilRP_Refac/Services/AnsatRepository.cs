using Microsoft.EntityFrameworkCore;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class AnsatRepository : EFCRepositoryBase<Ansat, RosBilDBContext>, IAnsatRepository
{
	protected override IQueryable<Ansat> GetAllWithIncludes(DbContext context)
	{
		return base.GetAllWithIncludes(context)
			.Include(b => b.Opgaves)
				.ThenInclude(opg => opg.Leje)
					.ThenInclude(leje => leje.Bil)
			.Include(b => b.Opgaves)
				.ThenInclude(opg => opg.Leje)
					.ThenInclude(leje => leje.Kunde);
	}
}
