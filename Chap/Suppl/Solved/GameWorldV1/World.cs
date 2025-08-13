
public enum DayState
{
	Day,
	Night
}

public class World
{
	private static Random _rng = new Random(Guid.NewGuid().GetHashCode());

	public Fighter? TheFighter { get; set; }
	public DayState DayOrNight { get; set; }

	public void GenerateEncounter(IOpponentFactory opponentFactory)
	{
		if (TheFighter == null)
		{
			throw new NullReferenceException("TheFighter is null, cannot do combat");
		}

		IOpponent theOpponent = opponentFactory.Create(TheFighter.Experience, DayOrNight); ;

		bool fighterWon = DoCombat(TheFighter, theOpponent);

		ReportCombatResult(TheFighter, theOpponent, fighterWon);
	}

	private bool DoCombat(Fighter fighter, IOpponent opponent)
	{
		double sumOfHP = fighter.HealthPoints + opponent.HealthPoints;

		double winProb = Math.Pow(fighter.HealthPoints, 2) / Math.Pow(sumOfHP, 2);
		double rng = _rng.NextDouble();

		return (winProb > rng);
	}

	private void ReportCombatResult(Fighter fighter, IOpponent opponent, bool fighterWon)
	{
		Console.WriteLine($"{fighter}  vs  {opponent.Description}  (during {DayOrNight})");
		Console.WriteLine($"{(fighterWon ? "Fighter" : "Opponent")} won");
		Console.WriteLine();
	}
}
