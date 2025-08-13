
public class OpponentFactoryExtended : IOpponentFactory
{
	public IOpponent Create(GameExperience experience, DayState dayState)
	{
		if (experience == GameExperience.Low)
		{
			return new IEnemyToIOpponentAdapter(new SpeedSlug(20));
		}
		else if (experience == GameExperience.Mid && dayState == DayState.Day)
		{
			return new WildBoar(50);
		}
		else if (experience == GameExperience.Mid && dayState == DayState.Night)
		{
			return new FeralBat();
		}
		else if (experience == GameExperience.High && dayState == DayState.Day)
		{
			return new IEnemyToIOpponentAdapter(new BlackRaven(3, 0));
		}
		else if (experience == GameExperience.High && dayState == DayState.Night)
		{
			return new GrizzlyBearToIOpponentAdapter(new GrizzlyBear(220, true));
		}
		else
		{
			throw new Exception("Uncovered case in Create");
		}
	}
}
