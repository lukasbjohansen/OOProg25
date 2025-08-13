
public enum NewsType
{
	Common,
	Breaking
}

public class NewsItem
{
	public NewsType NewsType { get; }
	public string Headline { get; }
	public string Body { get; }

	public NewsItem(NewsType newsType, string headline, string body)
	{
		NewsType = newsType;
		Headline = headline;
		Body = body;
	}

	public override string ToString()
	{
		string breaking = NewsType == NewsType.Breaking ? "[BREAKING] " : "[COMMON  ] ";
		return $"{breaking} {Headline.ToUpper()} ({Body})";
	}
}
