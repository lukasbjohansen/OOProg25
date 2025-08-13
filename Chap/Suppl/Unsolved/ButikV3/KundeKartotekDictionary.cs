
/// <summary>
/// Implementation af et kunde-kartotek ved brug af Dictionary-klassen
/// </summary>

public class KundeKartotekDictionary
{
    private Dictionary<int, Kunde> _kunder;

    /// <summary>
    /// Returnerer det totale antal kunder i kartoteket
    /// </summary>
    public int AntalKunder
    {
        get 
        { 
            return 0; // TODO
        } 
    }

    /// <summary>
    /// Returnerer det totale antal ordrer for kunderne i kartoteket
    /// </summary>
    public int TotaltAntalOrdrer
    {
        get
        {
            return 0; // TODO
        }
    }

    public KundeKartotekDictionary()
    {
        _kunder = new Dictionary<int, Kunde>();
    }

    public void OpretKunde(Kunde kunde)
    {
        // TODO
    }

    public bool SletKunde(int id)
    {
        return false; // TODO
    }

    public Kunde? FindKunde(int id)
    {
        return null; // TODO
    }

    public void UdskrivKunder()
    {
        // TODO
    }
}
