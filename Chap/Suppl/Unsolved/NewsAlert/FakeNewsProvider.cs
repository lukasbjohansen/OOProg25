
public class FakeNewsProvider : INewsSource
{
	public NewsItem News
	{
		get
		{
			return new NewsItem(NewsType.Breaking, "Denmark buys Alaska", "In a trade involving large amounts of Bacon and Lurpak Butter");
		}
	}
}
