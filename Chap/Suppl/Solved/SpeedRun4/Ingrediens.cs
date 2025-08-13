
public class Ingrediens
{
    public string Beskrivelse { get; }
    public int Vægt { get; set; }
    public bool AllergiRisiko { get; }

    public Ingrediens(string beskrivelse, int gram, bool allergiRisiko)
    {
        Beskrivelse = beskrivelse;
        Vægt = gram;
        AllergiRisiko = allergiRisiko;
    }

    public override string ToString()
    {
        return $"{Beskrivelse} ({Vægt} gram)   Allergi-risiko : {AllergiRisiko}";
    }
}
