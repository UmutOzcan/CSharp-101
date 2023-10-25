
Calisan calisan = new()
{
    Ad = "Umut",
    Soyad = "Ozcan",
    No = 5555555555,
    Departman = "Development"
};

calisan.CalisanBilgileri();
Console.ReadKey();


class Calisan
{
    public string Ad;

    public string Soyad;

    public long No;

    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi : {0}", Ad);
        Console.WriteLine("Calisan Soyadi : {0}", Soyad);
        Console.WriteLine("Calisan No : {0}", No);
        Console.WriteLine("Calisan Departmani : {0}", Departman);
    }

}