
public class NewsProvider : INewsGenerator, INewsSource
{
	private static Random _rng = new Random(Guid.NewGuid().GetHashCode());

	private List<NewsItem> _newsItems;

	public NewsItem News { get; private set; }

	public NewsProvider()
	{
		CreateNewsItems();
		Generate();
	}

	public void Generate()
	{
		// Vælger en tilfældig nyhed mellem de nyheder der er til rådighed.
		News = _newsItems[_rng.Next(_newsItems.Count)];
	}

	private void CreateNewsItems()
	{
		_newsItems = new List<NewsItem>()
		{
			new NewsItem(NewsType.Common,"Wallet found on city square", "City police assures the matter is handled"),
			new NewsItem(NewsType.Common,"Lost dog has returned home", "Owner thanks neighbours for help"),
			new NewsItem(NewsType.Common,"Comet may hit in 2192", "...or not"),
			new NewsItem(NewsType.Breaking,"Loose Gazelle in city", "We are still receiving news on this"),
			new NewsItem(NewsType.Breaking,"Zealand launches ZeaCoin crypto-currency", "Initial value will be 0.002 øre"),
			new NewsItem(NewsType.Breaking,"Roskilde bids for 2044 Olympics", "Viking Ship rowing to be added to competitions")
		};
	}
}
