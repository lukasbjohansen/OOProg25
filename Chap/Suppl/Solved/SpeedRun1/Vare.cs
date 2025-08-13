
public class Vare
{
    public string Navn { get; }
    public double Pris { get; set; }

    public Vare(string navn, double pris)
    {
        Navn = navn;
        Pris = pris;
    }

    public string SomTekst()
    {
        return $"{Navn} koster {Pris} kr.";
    }
}
