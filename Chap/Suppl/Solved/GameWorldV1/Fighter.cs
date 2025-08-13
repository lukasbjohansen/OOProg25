
public enum GameExperience
{
	Low,
	Mid,
	High
}

public class Fighter
{
	public string Name { get; }
	public int HealthPoints { get; set; }
	public GameExperience Experience { get; set; }

	public Fighter(string name, int healthPoints, GameExperience experience)
	{
		Name = name;
		HealthPoints = healthPoints;
		Experience = experience;
	}

	public override string ToString()
	{
		return $"Fighter {Name}, has {HealthPoints} HP ({Experience } experience)";
	}
}
