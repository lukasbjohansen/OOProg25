
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

public class EFCRepositoryAppBase<T> : EFCRepositoryBase<T> where T : class, IHarId
{
	protected override DbContext CreateDbContext()
	{
		return new RosBilDBContext();
	}
}
