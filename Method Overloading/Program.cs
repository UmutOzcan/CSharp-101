
Methods method = new();
method.EkranaYazdir("1 Degisken iceren string veri tipi");
method.EkranaYazdir(2);
method.EkranaYazdir("2 Degisken iceren " + "string veri tipi");

Console.ReadKey();

class Methods
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }

}

