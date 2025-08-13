
public class Kunde
{
    public string Navn { get; }
    public string Email { get; set; }
    public bool VIP { get; set; }

    public List<Vare> Varer { get; }

    public double SamletPrisForVarer
    {
        get 
        {
            double samletPris = 0;

            foreach (Vare vare in Varer)
            {
                samletPris = samletPris + vare.Pris;
            }

            return samletPris;
        }
    }

    public Kunde(string navn, string email)
    {
        Navn = navn;
        Email = email;
        VIP = false;

        Varer = new List<Vare>();
    }
}
