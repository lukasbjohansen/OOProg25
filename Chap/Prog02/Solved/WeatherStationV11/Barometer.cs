

public enum WeatherTypes
{
	Stormy,
	Rainy,
	Changing,
	Fair,
	VeryDry
}

/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public WeatherTypes WeatherDescription
    {
        get
        {
            if (Pressure < 980)
            {
                return WeatherTypes.Stormy;
            }
            else if (Pressure < 1000)
            {
                return WeatherTypes.Rainy;
            }
            else if (Pressure < 1020)
            {
                return WeatherTypes.Changing;
            }
            else if (Pressure < 1040)
            {
                return WeatherTypes.Fair;
            }
            else
            {
                return WeatherTypes.VeryDry;
            }
        }
    }

    public string WeatherDescriptionText
    {
        get 
        {
            if (WeatherDescription == WeatherTypes.VeryDry)
                return "Very Dry";
            else
                return $"{WeatherDescription}";
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