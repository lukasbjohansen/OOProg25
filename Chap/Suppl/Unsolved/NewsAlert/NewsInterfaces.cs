
public interface INewsGenerator
{
	/// <summary>
	/// Denne metode genererer en ny nyhed.
	/// </summary>
	void Generate();
}

public interface INewsSource
{
	/// <summary>
	/// Denne metode returnerer den seneste nyhed.
	/// </summary>
	NewsItem News { get; }
}