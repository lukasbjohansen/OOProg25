
public class Bil
{


    public override string ToString()
    {
        return $"{Mærke} {Model}, har kørt {Kilometer} km, er{(Ny ? "" : " ikke")} ny";
    }
}
