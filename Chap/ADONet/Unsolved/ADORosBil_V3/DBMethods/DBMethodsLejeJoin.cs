
using Microsoft.Data.SqlClient;

/// <summary>
/// Klasse til at arbejde med Leje-tabellen.
/// Denne klasse bruger en mere kompleks SELECT-statement (baseret på join af tabeller)
/// for at kunne oprette et nyt Leje-objekt.
/// </summary>
public class DBMethodsLejeJoin : DBMethodsBase<Leje>
{
	public DBMethodsLejeJoin(string connectionString)
	: base(connectionString, "Leje", $"(@Id , @KundeId, @BilId, @Dato, @AntalDage)")
	{
	}

	public override List<Leje> ReadAllFromDB()
	{
		List<Leje> data = new List<Leje>();

		string queryStr = "SELECT Kunde.Id as KundeId, Navn, Telefon, VIP, Bil.Id as BilId, Nummerplade, Model, PrisPrDag, Leje.Id as LejeId, Dato, AntalDage " +
			"FROM Kunde, Bil, Leje " +
			"WHERE (Leje.KundeId = Kunde.Id AND Leje.BilId = Bil.Id)";

		try
		{
			// Etablér DB-forbindelse (med brug af using-syntaksen)
			using SqlConnection connection = new SqlConnection(ConnectionString);
			connection.Open();

			// 2) Definér og udfør SQL-statement
			SqlCommand cmd = new SqlCommand(queryStr, connection);
			SqlDataReader reader = cmd.ExecuteReader();

			// 3) Processér de læste data
			while (reader.Read())
			{
				data.Add(GetRow(reader));
			}
		}
		catch (SqlException e)
		{
			SQLExceptionHandler(e);
		}

		return data;
	}

	protected override void AddParameterValues(SqlCommand cmd, Leje leje)
	{
		cmd.Parameters.AddWithValue("@Id", leje.Id);
		cmd.Parameters.AddWithValue("@KundeId", leje.Kunden.Id);
		cmd.Parameters.AddWithValue("@BilId", leje.Bilen.Id);
		cmd.Parameters.AddWithValue("@Dato", leje.Dato.ToString("yyyy-MM-dd"));
		cmd.Parameters.AddWithValue("@AntalDage", leje.AntalDage);
	}

	protected override Leje GetRow(SqlDataReader reader)
	{
		int kundeId = reader.GetInt32(reader.GetOrdinal("KundeId"));
		string navn = reader.GetString(reader.GetOrdinal("Navn"));
		int telefon = reader.GetInt32(reader.GetOrdinal("Telefon"));
		bool vip = reader.GetBoolean(reader.GetOrdinal("VIP"));

		int bilId = reader.GetInt32(reader.GetOrdinal("BilId"));
		string nummerplade = reader.GetString(reader.GetOrdinal("Nummerplade"));
		string model = reader.GetString(reader.GetOrdinal("Model"));
		int prisPrDag = reader.GetInt32(reader.GetOrdinal("PrisPrDag"));

		int lejeId = reader.GetInt32(reader.GetOrdinal("LejeId"));
		DateOnly dato = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("Dato")));
		int antalDage = reader.GetInt32(reader.GetOrdinal("AntalDage"));

		Kunde kunde = new Kunde(kundeId, navn, telefon, vip);
		Bil bil = new Bil(bilId, nummerplade, model, prisPrDag);
		Leje leje = new Leje(lejeId, kunde, bil, dato, antalDage);

		return leje;
	}
}
