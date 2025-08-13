
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

/// <summary>
/// Denne klasse rummer et antal metoder til at udføre typiske database-operationer,
/// såsom at læse, oprette og slette data.
/// Bemærk, at koden i denne klasse er specifikt rettet mod Kunde-tabellen.
/// </summary>
public class DBMethodsKunde
{
	private string _connectionString;

	public DBMethodsKunde(string connectionString)
	{
		_connectionString = connectionString;
	}

	/// <summary>
	/// // Læs alle Kunder fra DB og returnér dem i en liste.
	/// </summary>
	public List<Kunde> ReadAllFromDB()
	{
		List<Kunde> kunder = new List<Kunde>();
		string queryStr = "SELECT * FROM Kunde";

		try
		{
			// Etablér DB-forbindelse (med brug af using-syntaksen)
			using SqlConnection connection = new SqlConnection(_connectionString);
			connection.Open();

			// Definér og udfør SQL-statement
			SqlCommand cmd = new SqlCommand(queryStr, connection);
			SqlDataReader reader = cmd.ExecuteReader();

			// Processér de læste data
			while (reader.Read())
			{
				kunder.Add(GetRow(reader));
			}
		}
		catch (SqlException e)
		{
			SQLExceptionHandler(e);
		}

		return kunder;
	}

	/// <summary>
	/// Skriv et enkelt Kunde-objekt til Kunde-tabellen.
	/// </summary>
	public int WriteToDB(Kunde kunde)
	{
		string queryStr = "INSERT INTO Kunde VALUES " +
			$"(@Id , @Navn, @Telefon, @VIP)";

		try
		{
			// Etablér DB-forbindelse (med brug af using-syntaksen)
			using SqlConnection connection = new SqlConnection(_connectionString);
			connection.Open();

			// Definér SQL-statement (incl. at sætte parameter-værdier)
			SqlCommand cmd = new SqlCommand(queryStr, connection);
			AddParameterValues(cmd, kunde);

			// Udfør SQL-statement
			return cmd.ExecuteNonQuery();
		}
		catch (SqlException e)
		{
			SQLExceptionHandler(e);
		}

		return 0;
	}

	/// <summary>
	/// Slet det Kunde-objekt som matcher det givne Id fra Kunde-tabellen.
	/// </summary>
	public int DeleteFromDB(int id)
	{
		string queryStr = $"DELETE FROM Kunde WHERE Id = {id}";

		try
		{
			// Etablér DB-forbindelse (med brug af using-syntaksen)
			using SqlConnection connection = new SqlConnection(_connectionString);
			connection.Open();

			// Definér SQL-statement
			SqlCommand cmd = new SqlCommand(queryStr, connection);

			// Udfør SQL-statement
			return cmd.ExecuteNonQuery();
		}
		catch (SqlException e)
		{
			SQLExceptionHandler(e);
		}

		return 0;
	}


	/// <summary>
	/// Læs en enkelt række fra Kunde-tabellen, og brug det læste data til at
	/// oprette et Kunde-objekt.
	/// </summary>
	private Kunde GetRow(SqlDataReader reader)
	{
		int id = reader.GetInt32(reader.GetOrdinal("Id"));
		string navn = reader.GetString(reader.GetOrdinal("Navn"));
		int telefon = reader.GetInt32(reader.GetOrdinal("Telefon"));
		bool vip = reader.GetBoolean(reader.GetOrdinal("VIP"));

		return new Kunde(id, navn, telefon, vip);
	}

	/// <summary>
	/// Sæt parameter-værdierne i den parameteriserede query-string, 
	/// der skal bruges når vi skal udføre en INSERT-statement. 
	/// Værdierne tages fra det givne Kunde-objekt.
	/// </summary>
	private void AddParameterValues(SqlCommand cmd, Kunde kunde)
	{
		cmd.Parameters.AddWithValue("@Id", kunde.Id);
		cmd.Parameters.AddWithValue("@Navn", kunde.Navn);
		cmd.Parameters.AddWithValue("@Telefon", kunde.Telefon);
		cmd.Parameters.AddWithValue("@VIP", kunde.VIP);
	}

	/// <summary>
	/// Simpel håndtering af exceptions
	/// </summary>
	private void SQLExceptionHandler(SqlException sqlEx, [CallerMemberName] string? caller = null)
	{
		Console.WriteLine($"SqlException i {caller} : {sqlEx.Message}");
	}
}

