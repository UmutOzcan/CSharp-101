

public class Ranger : IOtomobil
{
    public int KacTekerlek()
    {
        return 4;
    }

    public Marka Marka()
    {
        return global::Marka.Ford;
    }

    public Renk Renk()
    {
        return global::Renk.Siyah;
    }
}