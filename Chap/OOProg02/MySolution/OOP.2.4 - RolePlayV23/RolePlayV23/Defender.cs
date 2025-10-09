using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Defender : Character
{
	#region Constructors
	public Defender(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
	{
	}
	#endregion
	#region Properties
	protected override int ReceiveDamageModifyChance
	{
		get { return 45; }
	}
	#endregion
	#region Methods
	protected override int CalculateModifiedReceivedDamage(int receivedDamage)
	{
		return (int) (receivedDamage * 0.5);
	}
	#endregion
}
