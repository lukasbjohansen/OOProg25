
/// <summary>
/// A very simple representation of a car
/// </summary>
public class Car
{
	#region Static fields
    private static int _totalCarsCreated = 0;
	#endregion
	#region Instance fields
	private string _licensePlate;
    private int _price;
    #endregion

    #region Constructor
    public Car(string licensePlate, int price)
    {
        _licensePlate = licensePlate;
        _price = price;
    }
    #endregion

    #region Properties
    public string LicensePlate
    {
        get { return _licensePlate; }
        set { _licensePlate = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public static int TotalCarsCreated
    {
        get { return _totalCarsCreated; }
	}
    #endregion
    public static string CalcChange(int amount) {
        Dictionary<string, int> coins = new() {
            { "500kr", 500 },
            { "200kr", 200 },
            { "100kr", 100 },
            { "50kr", 50 },
            { "20kr", 20 },
            { "10kr", 10 },
            { "5kr", 5 },
            { "2kr", 2 },
            { "1kr", 1 },
        };
        int[] coinTypes = coins.Values.ToArray();
        string[] coinNames = coins.Keys.ToArray();
        // Calc how many coins of each type are needed to make up the amount
        int[] coinsNeeded = new int[coinTypes.Length];
        int i = 0;
        while (amount > 0) {
            coinsNeeded[i] = amount / coinTypes[i];
            amount -= coinsNeeded[i] * coinTypes[i];
            i++;
        }
        string coinString = "";
        for (int j = 0; j < coinTypes.Length; j++) {
            if (coinsNeeded[j] == 0) continue;
            coinString += coinNames[j] + " " + coinsNeeded[j] + "\n";
        }
        return coinString;
    }
}