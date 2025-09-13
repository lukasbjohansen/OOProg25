/*
 * OOP.1.9 solution by Lukas Johansen
 */
/// <summary>
/// A very simple representation of a car
/// </summary>
public class Car {
    #region Static fields
    private static int _totalCarsCreated = 0;
    private static int _licensePlateUses = 0;
    private static int _priceUses = 0;
    #endregion
    #region Instance fields
    private string _licensePlate;
    private int _price;
    #endregion
    #region Constructor
    public Car(string licensePlate, int price) {
        _licensePlate = licensePlate;
        _price = price;
        _totalCarsCreated++;
    }
    #endregion
    #region Properties
    public string LicensePlate {
        get { 
            _licensePlateUses++;
            return _licensePlate; 
        }
        set { 
            _licensePlateUses++;
            _licensePlate = value; 
        }
    }
    public int Price {
        get { 
            _priceUses++;
            return _price; 
        }
        set { 
            _priceUses++;
            _price = value; 
        }
    }
    public static void PrintUsageStatistics() {
        Console.WriteLine($"Total cars created: {_totalCarsCreated}");
        Console.WriteLine($"License plate property accessed: {_licensePlateUses} times");
        Console.WriteLine($"Price property accessed: {_priceUses} times");
    }
    #endregion
}