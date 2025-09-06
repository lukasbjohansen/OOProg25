/*
 * OOP.1.6 solution by Lukas Johansen
 */

/// <summary>
/// This class represents a dice cup containing two dice.
/// </summary>
public class DiceCup
{
    #region Instance fields
    private List<Die> _dice = new List<Die>();
    #endregion

    #region Constructor
    public DiceCup(params int[] dieFaces)
    {
        foreach(int faces in dieFaces)
        {
            _dice.Add(new Die(faces));
        }
    }
    #endregion

    // Implement a property TotalValue: the sum of 
    // the face values of the dice in the cup
    public int TotalValue { get { 
            int total = 0;
            foreach(Die die in _dice)
            {
                total += die.FaceValue;
            }
            return total; 
        } }

    // Implement a method Shake: all the dice in the cup should be rolled
    //
    public void Shake() { 
        foreach(Die die in _dice)
        {
            die.Roll();
        }
    }
}
