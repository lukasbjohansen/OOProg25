
public class Bil
{
    public string Mærke { get; }
    public string Model { get; }
    public int Kilometer { get; set; }
    public bool Ny { get { return Kilometer < 100; } }

    public Bil(string mærke, string model, int kilometer)
    {
        Mærke = mærke;
        Model = model;
        Kilometer = kilometer;
    }

    public override string ToString()
    {
        return $"{Mærke} {Model}, har kørt {Kilometer} km, er{(Ny ? "" : " ikke")} ny";
    }
}
