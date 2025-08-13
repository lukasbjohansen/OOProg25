
public class IEnemyToIOpponentAdapter : IOpponent
{
	private IEnemy _adaptee;

	public IEnemyToIOpponentAdapter(IEnemy adaptee)
	{
		_adaptee = adaptee;
	}

	public string Description
	{
		get { return _adaptee.Label; }
	}

	public int HealthPoints
	{
		get { return _adaptee.Level * _adaptee.HPPerLevel; }
	}
}

public class GrizzlyBearToIOpponentAdapter : IOpponent
{
	private GrizzlyBear _adaptee;

	public GrizzlyBearToIOpponentAdapter(GrizzlyBear adaptee)
	{
		_adaptee = adaptee;
	}

	public string Description
	{
		get { return _adaptee.CreatureName; }
	}

	public int HealthPoints
	{
		get { return _adaptee.LifePoints; }
	}
}