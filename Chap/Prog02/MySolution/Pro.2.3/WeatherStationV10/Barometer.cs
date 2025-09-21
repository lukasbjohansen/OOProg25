/*
 * Pro.2.3 solution by Lukas Johansen
 */
/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public string WeatherDescription
    {
        get {
            if (Pressure < 980.0) return "Stormy";
            else if (Pressure < 1000.0) return "Rainy";
            else if (Pressure < 1020.0) return "Changing";
            else if (Pressure < 1040.0) return "Fair";
            else return "Very dry";
        }
    }
    public string WeatherDescSwitch {
        get {
            switch (Pressure) {
                case < 980.0:
                    return "Stormy";
                case < 1000.0:
                    return "Rainy";
                case < 1020.0:
                    return "Changing";
                case < 1040.0:
                    return "Fair";
                default:
                    return "Very dry";
            }
        }
    }
    #endregion

    #region Constructor
    public Barometer()
    {
        Pressure = 1000.0;
    }
    #endregion
}
