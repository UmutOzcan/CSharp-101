// Kullanicidan alinan inputlara gore islem yaptiran console uygulamasi

Methods method = new();
method.KullaniciSecimi();

class Methods
{
    // Main Islem
    public void KullaniciSecimi()
    {
        Console.WriteLine("Yapmak istediginiz islemi secin : ");
        Console.WriteLine("1) Girilen dizideki cift sayilari bul");
        Console.WriteLine("2) Girilen sayinin, girilen dizideki bolebildigi sayilari bul");
        Console.WriteLine("3) Girilen cumleyi tersten yaz");
        Console.WriteLine("4) Girilen cumledeki kelime ve karakter sayisini bul");
        Console.WriteLine("5) Cikis");
        // input control yapilmali
        int secim = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (secim)
        {
            case 1:
                Console.WriteLine("--- Girilen dizideki cift sayilari bul ---\n");
                Console.WriteLine("Gireceginiz dizinin uzunlugunu girin : ");
                // input control yapilmali
                CiftBulma(Convert.ToInt32(Console.ReadLine()));

                break;

            case 2:
                Console.WriteLine("--- Girilen sayinin, girilen dizideki bolebildigi sayilari bul ---\n");
                Console.WriteLine("Bulunmasini istediginiz sayiyi girin : ");
                // input control yapilmali
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nSayinin bulunacagi dizinin uzunlugunu girin : ");
                // input control yapilmali
                int length = Convert.ToInt32(Console.ReadLine());
                BolenBul(length, sayi);

                break;

            case 3:
                Console.WriteLine("--- Girilen cumleyi tersten yaz ---\n");
                // input control yapilmali
                TersYaz(Console.ReadLine());

                break;

            case 4:
                Console.WriteLine("--- Girilen cumledeki kelime ve karakter sayisini bul ---\n");
                // input control yapilmali
                CumleAnaliz(Console.ReadLine());

                break;

            default:
                Environment.Exit(0);
                break;
        }

        Console.WriteLine("\nMenuye donmek icin herhangi bir tusa basin !!");
        Console.ReadKey();
        Console.Clear();
        KullaniciSecimi();
    }

    // 1. Islem
    public void CiftBulma(int sayi)
    {
        int[] dizi = new int[sayi];

        Console.WriteLine("\n" + sayi + " adet sayi giriniz (Bir sayi girdikten sonra Enter'a basiniz !!) :");
        for (int i = 0; i < sayi; i++) // input control yapilmali
            dizi[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nCift olan sayilar : ");
        for (int i = 0; i < sayi; i++)
            if (dizi[i] % 2 == 0)
                Console.Write(dizi[i] + " ");
    }

    // 2. Islem
    public void BolenBul(int length, int sayi)
    {
        int[] dizi = new int[length];

        Console.WriteLine("\n" + length + " adet sayi giriniz (Bir sayi girdikten sonra Enter'a basiniz !!) :");
        for (int i = 0; i < length; i++) // input control yapilmali
            dizi[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n" + sayi + " sayisina bolunen sayilar :");
        for (int i = 0; i < length; i++)
            if (dizi[i] % sayi == 0)
                Console.Write(dizi[i] + " ");
    }

    // 3. Islem
    public void TersYaz(string cumle)
    {
        char[] charArray = cumle.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(charArray);
    }

    // 4. Islem
    public void CumleAnaliz(string cumle)
    {
        string[] kelimeSayisi = cumle.Split(" ");
        Console.WriteLine("Cumledeki kelime sayisi : " + kelimeSayisi.Length);
        Console.WriteLine("Cumledeki karakter sayisi : " + cumle.Length);
    }
}