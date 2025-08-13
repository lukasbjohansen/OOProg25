
public class NewsPublisher
{
	private INewsSource _newsSource;

	public NewsPublisher(INewsSource newsSource)
	{
		_newsSource = newsSource;
	}

	/// <summary>
	/// Denne metode udskriver enhver nyhed der læses fra _newsSource.
	/// </summary>
	public void ReportAllNews()
	{
		NewsItem news = _newsSource.News;
		Console.WriteLine($"All News: {FormatNews(news)}");
	}

	/// <summary>
	/// Denne metode udskriver kun "Common" nyheder der læses fra _newsSource.
	/// </summary>
	public void ReportCommonNews()
	{
		// TODO
	}

	/// <summary>
	/// Denne metode udskriver kun "Breaking" nyheder der læses fra _newsSource.
	/// </summary>
	public void ReportBreakingNews()
	{
		// TODO	
	}

	private string FormatNews(NewsItem news)
	{
		if (news == null)
			return "(no news ro report)";
		else
			return news.ToString();
	}
}
