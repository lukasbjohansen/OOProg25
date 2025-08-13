
public class Opskrift
{
    public string Beskrivelse { get; }
    public List<Ingrediens> Ingredienser { get; }

    public int SamletVægt
    {
        get 
        {
            return 0; // TODO -  skal implementeres korrekt.
        }
    }

    public bool AllergiVenlig
    {
        get
        {
            return true; // TODO -  skal implementeres korrekt.
        }
    }

    public Opskrift(string beskrivelse)
    {
        Beskrivelse = beskrivelse;
        Ingredienser = new List<Ingrediens>();
    }
}
