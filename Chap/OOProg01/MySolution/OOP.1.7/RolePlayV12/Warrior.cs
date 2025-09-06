/*
 * OOP.1.7 solution by Lukas Johansen
 */

public class Warrior
{
    #region Instance fields
    private string _name;
    private int _hitPoints;
    private Sword _sword;
    private Sword? _secondarySword;
    private double _damageMultiplier;
    #endregion

    #region Constructor
    public Warrior(string name, int hitPoints, Sword sword, Sword? secondarySword = null, double damageFactor = 1)
    {
        _name = name;
        _hitPoints = hitPoints;
        _sword = sword;
        _secondarySword = secondarySword;
        _damageMultiplier = damageFactor;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public int HitPoints
    {
        get { return _hitPoints; }
    }

    public bool Dead
    {
        get { return _hitPoints <= 0; }
    }
    #endregion

    #region Methods
    public void ReceiveDamage(int points)
    {
        _hitPoints = _hitPoints - points;
    }

    public int DealDamage()
    {
        return (int) (_sword.DealDamage() * _damageMultiplier);
    }

    public string GetInfo()
    {
        return $"{Name} has {HitPoints} hit points ({(Dead ? "dead" : "alive")})";
    }

    public void ToggleSwords()
    {
        if (_secondarySword == null) return;
        Sword temp = _sword;
        _sword = _secondarySword;
        _secondarySword = temp;
    }
    #endregion
}