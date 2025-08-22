namespace RosBilRP.Models;

public class Bil : IHarId
{
	public int Id { get; set; }
	public string Nummerplade { get; set; }
	public string Model { get; set; }
	public int PrisPrDag { get; set; }

	public string NummerpladeOgModel { get { return $"{Nummerplade} ({Model})"; } }

	public Bil()
	{
	}

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