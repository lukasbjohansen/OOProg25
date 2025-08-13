
public class Opskrift
{
    public string Beskrivelse { get; }
    public List<Ingrediens> Ingredienser { get; }


    public int SamletVægt
    {
        get 
        {
            int samletVægt = 0;

            foreach (Ingrediens ing in Ingredienser)
            {
                samletVægt = samletVægt + ing.Vægt;
            }

            return samletVægt;
        }
    }

    public bool AllergiVenlig
    {
        get
        {
            foreach (Ingrediens ing in Ingredienser)
            {
                if (ing.AllergiRisiko)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public Opskrift(string beskrivelse)
    {
        Beskrivelse = beskrivelse;
        Ingredienser = new List<Ingrediens>();
    }
}
