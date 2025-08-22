using Microsoft.EntityFrameworkCore;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class KundeRepository : EFCRepositoryBase<Kunde, RosBilDBContext>, IKundeRepository
{
	protected override IQueryable<Kunde> GetAllWithIncludes(DbContext context)
	{
		return base.GetAllWithIncludes(context)
			.Include(b => b.Lejes);
	}

	public List<Kunde> AllVIP
	{
		get { return All.Where(kunde => kunde.Vip).ToList(); }
	}
}
