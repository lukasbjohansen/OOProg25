
using Microsoft.Data.SqlClient;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class BilRepository : ADORepositoryBase<Bil>, IBilRepository
{
	public BilRepository() : base("Bil", $"(@Id , @Nummerplade, @Model, @PrisPrDag)")
	{
	}

	protected override Bil GetRow(SqlDataReader reader)
	{
		int id = reader.GetInt32(reader.GetOrdinal("Id"));
		string nummerplade = reader.GetString(reader.GetOrdinal("Nummerplade"));
		string model = reader.GetString(reader.GetOrdinal("Model"));
		int prisPrDag = reader.GetInt32(reader.GetOrdinal("PrisPrDag"));

		return new Bil(id, nummerplade, model, prisPrDag);
	}

	protected override void AddParameterValues(SqlCommand cmd, Bil bil)
	{
		cmd.Parameters.AddWithValue("@Id", bil.Id);
		cmd.Parameters.AddWithValue("@Nummerplade", bil.Nummerplade);
		cmd.Parameters.AddWithValue("@Model", bil.Model);
		cmd.Parameters.AddWithValue("@PrisPrDag", bil.PrisPrDag);
	}
}
