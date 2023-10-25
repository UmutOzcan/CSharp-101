
Calisan calisan1 = new()
{
    Ad = "Umut",
    Soyad = "Ozcan",
    No = 55555555555,
    Departman = "Lojistik"
};
calisan1.CalisanBilgileri();

Calisan calisan2 = new("Yusuf", "Ozcan", 444444444, "Yazılım");
calisan2.CalisanBilgileri();

Console.ReadKey();


class Calisan
{
    public string? Ad;

    public string? Soyad;

    public long No;

    public string? Departman;

    public Calisan()
    {
    }

    public Calisan(string Ad, string Soyad, long No, string Departman)
    {
        this.Ad = Ad;
        this.Soyad = Soyad;
        this.No = No;
        this.Departman = Departman;

    }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi : {0}", Ad);
        Console.WriteLine("Calisan Soyadi : {0}", Soyad);
        Console.WriteLine("Calisan No : {0}", No);
        Console.WriteLine("Calisan Departmani : {0}", Departman);
        Console.WriteLine("\n");
    }

}