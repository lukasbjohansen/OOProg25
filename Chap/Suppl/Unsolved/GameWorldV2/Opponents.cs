
public interface IOpponent
{
	string Description { get; }
	int HealthPoints { get; }
}

// Repræsenterer de modstandere man kan møde i spillet,
// som vi selv har udviklet.
// NB: Disse klasser må IKKE ændres!

public class WildBoar : IOpponent
{
	public string Description { get; }
	public int HealthPoints { get; }
	public double LootValue { get; }

	public WildBoar(double lootValue)
	{
		Description = "Wild Boar";
		HealthPoints = 85;
		LootValue = lootValue;
	}
}

public class SmallSnake : IOpponent
{
	public string Description { get; }
	public int HealthPoints { get; }
	public bool HasPoison { get; }

	public SmallSnake(double lootValue, bool hasPoison)
	{
		Description = "Small Snake";
		HealthPoints = 35;
		HasPoison = hasPoison;
	}
}

public class FeralBat : IOpponent
{
	public string Description { get; }
	public int HealthPoints { get; }
	public double LootValue { get; }

	public FeralBat()
	{
		Description = "Feral Bat";
		HealthPoints = 70;
		LootValue = 25;
	}
}

public abstract class Tiger : IOpponent
{
	public string Description { get; }
	public int HealthPoints { get; }

	protected Tiger(string description, int healthPoints)
	{
		Description = description;
		HealthPoints = healthPoints;
	}
}

public class NightStalker : Tiger
{
	public NightStalker() 
		: base("Night Stalker (Tiger)", 160)
	{
	}
}

public class BengaliCat : Tiger
{
	public BengaliCat()
		: base("Bengali Cat (Tiger)", 140)
	{
	}
}