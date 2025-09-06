/*
 * OOP.1.5 solution by Lukas Johansen
 */

public class Clock
{
    #region instance fields
    private int _timeInMinutes;
    #endregion

    #region constructors
    public Clock()
    {
        _timeInMinutes = 0;
    }
    #endregion

    #region properties
    public int Hours { get {  return _timeInMinutes / 60; } }
    public int Minutes { get { return _timeInMinutes % 60; } }
    public string TimeString { get { return $"{Hours:D2}:{Minutes:D2}"; } }
    #endregion

    #region methods
    int GetMinutes(int hours, int minutes)
    {
        hours = Math.Abs(hours);
        minutes = Math.Abs(minutes);
        return (hours * 60 + minutes) % (24 * 60);
    }
    public void SetTime(int hours, int minutes)
    {
        _timeInMinutes = GetMinutes(hours, minutes);
    }
    public void AddOneMinute()
    {
        // Make sure it wraps by using the GetMinutes method
        _timeInMinutes = GetMinutes(Hours, Minutes + 1);
    }
    #endregion

}

