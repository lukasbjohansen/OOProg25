using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockV10;
public class Clock2 {
	#region Instance fields
	private int _minutes;
	private int _hours;
	#endregion
	#region Constructors
	public Clock2(int hours = 0, int minutes = 0) {
		_minutes = minutes;
		_hours = hours;
	}
	#endregion
	#region Properties
	#endregion
	#region Methods
	public void SetTime(int hours, int minutes) {
		_minutes = minutes;
		_hours = hours;
	}
	public void PrintTime() {
		Console.WriteLine($"{_hours:D2}:{_minutes:D2}");
	}
	public void AdvanceOneMinute() {
		_minutes++;
	}
	#endregion
}
