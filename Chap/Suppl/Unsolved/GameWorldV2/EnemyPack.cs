
// Repræsenterer de modstandere man kan møde i spillet,
// som vi har købt af en tredjepartsleverandør.
// NB: Disse klasser må IKKE ændres!

public interface IEnemy
{
	string Label { get; }
	int Level { get; }
	int HPPerLevel { get; }
	double ValueInGold { get; }
}

public class SpeedSlug : IEnemy
{
	public string Label { get; }
	public int Level { get { return 1; } }
	public int HPPerLevel { get; }
	public double ValueInGold { get; }

	public SpeedSlug(int hpPerLevel)
	{
		Label = "Speed Slug";
		HPPerLevel = hpPerLevel;
		ValueInGold = 12;
	}
}

public class BlackRaven : IEnemy
{
	public string Label { get; }
	public int Level { get; }
	public int HPPerLevel { get { return 25; } }
	public double ValueInGold { get; }

	public BlackRaven(int level, double valueInGold)
	{
		Label = "Black Raven";
		Level = level;
		ValueInGold = valueInGold;
	}
}

public class GrizzlyBear
{
	public string CreatureName { get; }
	public int LifePoints { get; }
	public bool CanBeSkinned { get; }

	public GrizzlyBear(int lifePoints, bool canBeSkinned)
	{
		CreatureName = "Grizzly Bear";
		LifePoints = lifePoints;
		CanBeSkinned = canBeSkinned;
	}
}
