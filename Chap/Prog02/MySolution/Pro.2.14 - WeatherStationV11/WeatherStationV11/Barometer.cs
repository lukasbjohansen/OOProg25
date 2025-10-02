
public enum WeatherType
{
    Stormy,
    Rainy,
    Changing,
    Fair,
    Very_Dry
}

/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public WeatherType WeatherDescription
    {
        get
        {
            if (Pressure < 980)
            {
                return WeatherType.Stormy;
            }
            else if (Pressure < 1000)
            {
                return WeatherType.Rainy;
            }
            else if (Pressure < 1020)
            {
                return WeatherType.Changing;
            }
            else if (Pressure < 1040)
            {
                return WeatherType.Fair;
            }
            else
            {
                return WeatherType.Very_Dry;
            }
        }
    }
	#endregion

	#region Constructor
	public Barometer()
    {
        Pressure = 1013.0;
    }
    #endregion
}