
public class BilFlåde
{
    private List<Bil> _biler;

    public BilFlåde()
    {
        _biler = new List<Bil>();
    }

    public void TilføjBil(Bil bil)
    {
        _biler.Add(bil);
    }

    /// <summary>
    /// Skal returnere antallet af biler i bilflåden, 
    /// hvis mærke matcher det mærke som gives i parameteren.
    /// </summary>
    public int HvorMangeAfDetteMærke(string mærke)
    {
        int antal = 0;

        foreach (Bil bil in _biler)
        {
            if (bil.Mærke == mærke)
            {
                antal++;
            }
        }

        return antal;
    }

    /// <summary>
    /// Skal returnere den førte nye bil i bilflåden.
    /// Hvis der ikke er nogen nye biler, skal metoden returnere null.
    /// </summary>
    public Bil? FindFørsteNyeBil()
    {
        foreach (Bil bil in _biler)
        {
            if (bil.Ny)
            {
                return bil;
            }
        }

        return null;
    }

    public override string ToString()
    {
        string tekst = "Bilflåde: \n";
        tekst += "-------------------\n";

        foreach (Bil bil in _biler)
        {
            tekst += $"{bil}\n";
        }

        tekst += "\n";

        return tekst;
    }
}
