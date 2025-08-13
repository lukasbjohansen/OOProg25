
using EFCRosBil;
using Microsoft.EntityFrameworkCore;

public class DataService
{
	public List<Kunde> HentAlleKunder()
	{
		RosBilDBContext context = new RosBilDBContext();
		return context.Set<Kunde>().ToList();
	}

	public List<Bil> HentAlleBiler()
	{
		RosBilDBContext context = new RosBilDBContext();
		return context.Set<Bil>().ToList();
	}

	public List<Leje> HentAlleUdlejninger()
	{
		RosBilDBContext context = new RosBilDBContext();
		return context.Set<Leje>().Include(l => l.Kunde).Include(l => l.Bil).ToList();
	}
}
