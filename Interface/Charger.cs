

public class Charger : IOtomobil
{
    public int KacTekerlek()
    {
        return 4;
    }

    public Marka Marka()
    {
        return global::Marka.Dodge;
    }

    public Renk Renk()
    {
        return global::Renk.Beyaz;
    }
}