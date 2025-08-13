
/// <summary>
/// Vores standard-factory, som kun kan returnere modstandere
/// vi selv har udviklet.
/// NB: Denne klasse må IKKE ændres!
/// </summary>
public class OpponentFactoryStandard : IOpponentFactory
{
	public IOpponent Create(GameExperience experience, DayState dayState)
	{
		if (experience == GameExperience.Low)
		{
			return new SmallSnake(35, false);
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
			return new BengaliCat();
		}
		else if (experience == GameExperience.High && dayState == DayState.Night)
		{
			return new NightStalker();
		}
		else
		{
			throw new Exception("Uncovered case in Create");
		}
	}
}
