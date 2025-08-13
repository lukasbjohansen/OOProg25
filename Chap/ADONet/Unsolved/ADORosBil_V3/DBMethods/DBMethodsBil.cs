
using Microsoft.Data.SqlClient;

/// <summary>
/// Klasse til at arbejde med Bil-tabellen.
/// </summary>
public class DBMethodsBil : DBMethodsBase<Bil>
{
	public DBMethodsBil(string connectionString)
		: base(connectionString, "Bil", $"(@Id , @Nummerplade, @Model, @PrisPrDag)")
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
