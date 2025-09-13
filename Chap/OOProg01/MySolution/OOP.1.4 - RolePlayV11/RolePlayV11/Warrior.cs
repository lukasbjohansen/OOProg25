/*
 * OOP.1.4 solution by Lukas Johansen
 */

public class Warrior
{
    #region Instance fields
    private string _name;
    private int _level;
    private int _hitPoints;
    #endregion

    #region Constructor
    public Warrior(string name, int hitPoints)
    {
        _name = name;
        _level = 1;
        _hitPoints = hitPoints;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public int Level
    {
        get { return _level; }
    }

    public int HitPoints { get { return _hitPoints; } }
    public bool Dead { get { return _hitPoints <= 0; } }
    #endregion

    #region Methods
    public void LevelUp()
    {
        _level = _level + 1;
    }
    public void TakeDamage(int amount)
    {
        _hitPoints -= amount;
    }
    public int DealDamage(Warrior? target = null)
    {
        int random = new Random().Next(10, 30);
        if (target != null) {
            target.TakeDamage(random);
        }
        return random;
    }
    #endregion
}
