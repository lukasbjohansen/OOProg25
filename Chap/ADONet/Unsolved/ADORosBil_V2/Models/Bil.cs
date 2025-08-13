
public class Bil : IHarId
{
	public int Id { get; set; }
	public string Nummerplade { get; }
	public string Model { get; }
	public int PrisPrDag { get; set; }

	public Bil(int id, string nummerplade, string model, int prisPrDag)
	{
		Id = id;
		Nummerplade = nummerplade;
		Model = model;
		PrisPrDag = prisPrDag;
	}

	public override string ToString()
	{
		return $"[Bil {Id}] {Nummerplade} ({Model}), koster {PrisPrDag} kr./dag";
	}
}