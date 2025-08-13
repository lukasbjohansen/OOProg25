
public class Kasse
{
    public string Materiale { get; }
    public double Længde { get; }
    public double Bredde { get; }
    public double Højde { get; }
    public bool Fyldt { get; set; }

    public double Volumen 
    { 
        get { return Længde * Bredde * Højde; }
    }

    public Kasse(string materiale, double bredde, double højde, double længde)
    {
        Materiale = materiale;

        Bredde = bredde;
        Højde = højde;
        Længde = længde;

        Fyldt = false;
    }
}
