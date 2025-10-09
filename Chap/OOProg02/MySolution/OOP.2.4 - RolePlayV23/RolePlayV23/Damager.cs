using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Damager : Character
{
	#region Constructors
	public Damager(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
	{
	}
	#endregion
	#region Properties
	protected override int DealDamageModifyChance
	{
		get { return 40; }
	}
	#endregion
	#region Instance Methods
	protected override int CalculateModifiedDealDamage(int dealtDamage)
	{
		return dealtDamage * 2;
	}
	#endregion

}
