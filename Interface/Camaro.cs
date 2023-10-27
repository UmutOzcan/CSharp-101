

public class Camaro : IOtomobil
{
    public int KacTekerlek()
    {
        return 4;
    }

    public Marka Marka()
    {
        return global::Marka.Chevrolet;
    }

    public Renk Renk()
    {
        return global::Renk.Sarı;
    }
}