
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

/// <summary>
/// Denne klasse rummer et antal metoder til at udføre typiske database-operationer,
/// såsom at læse, oprette og slette data.
/// Bemærk, at denne klasse IKKE er rettet mod en specifik tabel. Den er derimod lavet
/// så generelt som muligt, og skal således være base-klasse for DBMethods...-klasser
/// rettet mod en specifik tabel.
/// </summary>
public abstract class DBMethodsBase<T> where T : IHarId
{
    private string _tableName;
    private string _parameterList;

    protected string ConnectionString { get; }

	/// <summary>
	/// Constructoren tager flere parametre, som definerer
	/// 1) Hvordan vi skal connecte til databasen (via den givne connection-string)
	/// 2) Hvilken tabel der skal læses data fra
	/// 3) Parameter-liste til brug ved INSERT-statement
	/// </summary>
	public DBMethodsBase(string connectionString, string tableName, string parameterList)
    {
		ConnectionString = connectionString;

        _tableName = tableName;
        _parameterList = parameterList;
    }


	/// <summary>
	/// Læs alle rækker fra _tableName og returnér de tilsvarende objekter (af typen T) i en liste.
	/// </summary>  
	public virtual List<T> ReadAllFromDB()
    {
        List<T> data = new List<T>();
        string queryStr = $"SELECT * FROM {_tableName}";

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

	/// <summary>
	/// Læs den række fra _tableName hvor Id er lig med det givne Id, 
	/// og returner dettilsvarende objekt.
	/// (NB: Denne metode er nok ikke implementeret så effektivt...)
	/// </summary>
	public T? ReadFromDB(int id)
	{
        return ReadAllFromDB().FirstOrDefault(t => t.Id == id);
	}

	/// <summary>
	/// Skriv et enkelt objekt af typen T til tabellen _tableName.
	/// </summary>
	public int WriteToDB(T t)
    {
        string queryStr = $"INSERT INTO {_tableName} VALUES " + _parameterList;

        try
        {
			// Etablér DB-forbindelse (med brug af using-syntaksen)
			using SqlConnection connection = new SqlConnection(ConnectionString);
			connection.Open();

			// Definér SQL-statement (incl. at sætte parameter-værdier)
			SqlCommand cmd = new SqlCommand(queryStr, connection);
			AddParameterValues(cmd, t);

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
	/// Slet objektet som matcher det givne Id fra _tableName tabellen.
	/// </summary>
	public int DeleteFromDB(int id)
    {
        string queryStr = $"DELETE FROM {_tableName} WHERE Id = {id}";

        try
        {
			// Etablér DB-forbindelse (med brug af using-syntaksen)
			using SqlConnection connection = new SqlConnection(ConnectionString);
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
	/// Læs en enkelt række fra _tableName, og brug det læste data til at
	/// oprette et objekt af typen T.
	/// </summary>
	protected abstract T GetRow(SqlDataReader reader);

	/// <summary>
	/// Sæt parameter-værdierne i den parameteriserede query-string, der skal bruges når
	/// vi skal udføre en INSERT-statement. Værdierne tages fra det givne objekt af typen T.
	/// </summary>
	protected abstract void AddParameterValues(SqlCommand cmd, T t);

	/// <summary>
	/// Simpel håndtering af exceptions
	/// </summary>
	protected void SQLExceptionHandler(SqlException sqlEx, [CallerMemberName] string? caller = null)
	{
		Console.WriteLine($"SqlException i {caller} : {sqlEx.Message}");
	}
}
