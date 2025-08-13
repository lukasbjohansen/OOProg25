
using EFCRosBil;

public class MockKundeRepo : InMemoryRepo<Kunde>
{
	protected override void Populate()
	{
		Create(Kunde.Construct("Per", 12312399, false));
		Create(Kunde.Construct("Inge", 99123123, true));
		Create(Kunde.Construct("Ole", 1234612, true));
		Create(Kunde.Construct("Yrsa", 98765432, false));
	}
}


public class MockBilRepo : InMemoryRepo<Bil>
{
	protected override void Populate()
	{
		Create(Bil.Construct("ZZ 21212", "Porsche 911", 2400));
		Create(Bil.Construct("YY 34341", "Mercedes E450", 1800));
		Create(Bil.Construct("VV 11227", "Audi A6", 1200));
		Create(Bil.Construct("XX 12123", "Mercedes A160", 850));
	}
}

public class MockLejeRepo : InMemoryRepo<Leje>
{
	public override int Create(Leje t)
	{
		return base.Create(ResolveObjectRefs(t));
	}

	protected override void Populate()
	{
		Create(Leje.Construct(1, 1, new DateOnly(2025, 4, 1), 5));
		Create(Leje.Construct(2, 2, new DateOnly(2025, 4, 2), 6));
	}

	private Leje ResolveObjectRefs(Leje leje)
	{
		// Sæt objekt-referencer ud fra fremmednøgler

		MockBilRepo bilRepo = new MockBilRepo();
		MockKundeRepo kundeRepo = new MockKundeRepo();

		leje.Bil = bilRepo.Read(leje.BilId);
		leje.Kunde = kundeRepo.Read(leje.KundeId);

		return leje;
	}
}
