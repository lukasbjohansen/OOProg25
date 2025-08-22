using Microsoft.EntityFrameworkCore;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class OpgaveRepository : EFCRepositoryBase<Opgave, RosBilDBContext>, IOpgaveRepository
{
	public void Afslut(int opgId)
	{
		using DbContext context = new RosBilDBContext();

		Opgave? opg = Read(opgId) ?? throw new ArgumentException("Opgave ikke fundet...");
		opg.Afsluttet = true;

		context.Update(opg);
		context.SaveChanges();
	}

	protected override IQueryable<Opgave> GetAllWithIncludes(DbContext context)
	{
		return base.GetAllWithIncludes(context)
			.Include(opg => opg.Ansat)
			.Include(opg => opg.Leje)
			  .ThenInclude(leje => leje.Bil)
			.Include(opg => opg.Leje)
			  .ThenInclude(leje => leje.Kunde);
	}
}
