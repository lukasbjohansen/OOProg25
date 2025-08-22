
using Microsoft.Data.SqlClient;
using RosBilRP.Models;

namespace RosBilRP.Services;

/// <summary>
/// Base-klasse for en ADO-baseret implementation af IRepository interfacet,
/// ved hjælp af DBMethods-klasserne.
/// </summary>
public abstract class ADORepositoryBase<T> : IRepository<T> where T : IHarId
{
	private string _tableName;
	private string _parameterList;

	protected string ConnectionString 
	{ 
		get
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.DataSource = "(localdb)\\MSSQLLocalDB";
			builder.InitialCatalog = "RosBilDB";

			return builder.ConnectionString;
		}
	}

	public ADORepositoryBase(string tableName, string parameterList)
    {
		_tableName = tableName;
		_parameterList = parameterList;
	}

	public virtual List<T> All
	{
		get 
        {
			List<T> data = new List<T>();
			string queryStr = $"SELECT * FROM {_tableName}";

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

			return data;
		}
	}

	public virtual int Create(T t)
    {
        int id = NextId();
        t.Id = id;

		string queryStr = $"INSERT INTO {_tableName} VALUES " + _parameterList;

		// Etablér DB-forbindelse (med brug af using-syntaksen)
		using SqlConnection connection = new SqlConnection(ConnectionString);
		connection.Open();

		// Definér SQL-statement (incl. at sætte parameter-værdier)
		SqlCommand cmd = new SqlCommand(queryStr, connection);
		AddParameterValues(cmd, t);

		// Udfør SQL-statement
		cmd.ExecuteNonQuery();

		return id;
    }

    public virtual bool Delete(int id)
    {
		string queryStr = $"DELETE FROM {_tableName} WHERE Id = {id}";

		// Etablér DB-forbindelse (med brug af using-syntaksen)
		using SqlConnection connection = new SqlConnection(ConnectionString);
		connection.Open();

		// Definér SQL-statement
		SqlCommand cmd = new SqlCommand(queryStr, connection);

		// Udfør SQL-statement
		return cmd.ExecuteNonQuery() > 0;
	}

    public virtual T? Read(int id)
    {
		string queryStr = $"SELECT * FROM {_tableName} WHERE Id = {id}";

		// Etablér DB-forbindelse (med brug af using-syntaksen)
		using SqlConnection connection = new SqlConnection(ConnectionString);
		connection.Open();

		// 2) Definér og udfør SQL-statement
		SqlCommand cmd = new SqlCommand(queryStr, connection);
		SqlDataReader reader = cmd.ExecuteReader();

		// 3) Processér de læste data (der bør kun være een matchende row)
		return reader.Read() ? GetRow(reader) : default;
	}

    private int NextId()
    {
        return All.Select(t => t.Id).DefaultIfEmpty(0).Max() + 1;
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
}
