
using Microsoft.Data.SqlClient;

/// <summary>
/// Klasse til at arbejde med Leje-tabellen.
/// Denne klasse skal bruge referencer til DBMethodsBil og DBMethodsKunde 
/// for at kunne oprette et nyt Leje-objekt.
/// </summary>
public class DBMethodsLeje : DBMethodsBase<Leje>
{
	private DBMethodsBil _dbmBil;
	private DBMethodsKunde _dbmKunde;

	public DBMethodsLeje(string connectionString, DBMethodsBil dbmBil, DBMethodsKunde dbmKunde)
	: base(connectionString, "Leje", $"(@Id , @KundeId, @BilId, @Dato, @AntalDage)")
	{
		_dbmBil = dbmBil;
		_dbmKunde = dbmKunde;
	}

	protected override Leje GetRow(SqlDataReader reader)
	{
		int id = reader.GetInt32(reader.GetOrdinal("Id"));
		int kundeId = reader.GetInt32(reader.GetOrdinal("KundeId"));
		int bilId = reader.GetInt32(reader.GetOrdinal("BilId"));
		DateOnly dato = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("Dato")));
		int antalDage = reader.GetInt32(reader.GetOrdinal("AntalDage"));

		return Helpers.CreateLeje(id, kundeId, bilId, dato, antalDage, _dbmKunde, _dbmBil);
	}

	protected override void AddParameterValues(SqlCommand cmd, Leje leje)
	{
		cmd.Parameters.AddWithValue("@Id", leje.Id);
		cmd.Parameters.AddWithValue("@KundeId", leje.Kunden.Id);
		cmd.Parameters.AddWithValue("@BilId", leje.Bilen.Id);
		cmd.Parameters.AddWithValue("@Dato", leje.Dato.ToString("yyyy-MM-dd"));
		cmd.Parameters.AddWithValue("@AntalDage", leje.AntalDage);
	}
}
