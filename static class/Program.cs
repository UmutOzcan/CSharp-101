//Static sınıf üyesine erişim
Console.WriteLine("Öğrenci sayısı: {0}", Ogrenci.OgrenciSayisi);

//Static olmayan sinif üyesine erişim
Ogrenci ogrenci1 = new()
{
    Isim = "Deniz",
    Soyisim = "Arda"
};

Ogrenci ogrenci2 = new()
{
    Isim = "Ayşe",
    Soyisim = "Yılmaz"
};

Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);

Console.ReadKey();

class Ogrenci
{
    public static int OgrenciSayisi = 0;
    public string Isim;
    public string Soyisim;
    public Ogrenci()
    {
        OgrenciSayisi++;
    }
}