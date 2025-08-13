
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


	public void GenerateEncounter()
	{
		if (TheFighter == null)
		{
			throw new NullReferenceException("TheFighter is null, cannot do combat");
		}

		IOpponent? theOpponent = null;

		if (TheFighter.Experience == GameExperience.Low)
		{
			theOpponent = new SmallSnake(35, false);
		}
		else if (TheFighter.Experience == GameExperience.Mid && DayOrNight == DayState.Day)
		{
			theOpponent = new WildBoar(50);
		}
		else if (TheFighter.Experience == GameExperience.Mid && DayOrNight == DayState.Night)
		{
			theOpponent = new FeralBat();
		}
		else if (TheFighter.Experience == GameExperience.High && DayOrNight == DayState.Day)
		{
			theOpponent = new BengaliCat();
		}
		else if (TheFighter.Experience == GameExperience.High && DayOrNight == DayState.Night)
		{
			theOpponent = new NightStalker();
		}
		else
		{
			throw new Exception("Uncovered case in DoCombat");
		}

		if (theOpponent == null)
		{
			throw new NullReferenceException("Opponent is null, cannot do combat");
		}

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
