// Kullanicidan alinan inputlara gore islem yaptiran console uygulamasi

using System.Collections;

Methods method = new();
method.KullaniciSecimi();

class Methods
{
    // Main Islem
    public void KullaniciSecimi()
    {
        Console.WriteLine("Yapmak istediginiz islemi secin : ");
        Console.WriteLine("1) Girilen sayilari asalligina gore listele");
        Console.WriteLine("2) Girilen sayilarin en buyuk 3 ve en kucuk 3'unu bul");
        Console.WriteLine("3) Girilen cumledeki sesli harfleri bul");
        Console.WriteLine("4) Cikis");
        // input control yapilmali
        int secim = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (secim)
        {
            case 1:
                AsalMi();

                break;

            case 2:
                Bul();

                break;

            case 3:
                UnluBul();

                break;

            default:
                Environment.Exit(0);
                break;
        }

        Console.WriteLine("\n\nMenuye donmek icin herhangi bir tusa basin !!");
        Console.ReadKey();
        Console.Clear();
        KullaniciSecimi();
    }

    // 1. Islem
    public void AsalMi()
    {
        Console.WriteLine("--- Girilen sayilari asalligina gore listele ---\n");
        Console.WriteLine("20 adet sayi giriniz (Her bir sayiyi girdikten sonra Enter'a basiniz.) : ");

        ArrayList arrayListAsal = new();
        ArrayList arrayListAsalDegil = new();


        for (int i = 0; i < 20; i++)
        {
            try
            {
                int veri = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(veri) == false) arrayListAsalDegil.Add(veri);
                if (IsPrime(veri) == true) arrayListAsal.Add(veri);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());

            }
        }

        arrayListAsal.Sort();
        arrayListAsalDegil.Sort();
        Console.Write("\nAsal sayilar : ");
        foreach (var item in arrayListAsal)
            Console.Write(item + " - ");
        Console.Write("\nAsal olmayan sayilar : ");
        foreach (var item in arrayListAsalDegil)
            Console.Write(item + " - ");

    }
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number <= 3)
        {
            return true;
        }

        if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    // 2. Islem
    public void Bul()
    {
        Console.WriteLine("--- Girilen sayilarin en buyuk 3 ve en kucuk 3'unu bul ---\n");
        Console.WriteLine("20 adet sayi giriniz (Her bir sayiyi girdikten sonra Enter'a basiniz.) : ");

        int[] array = new int[20];

        for (int i = 0; i < 20; i++)
        {
            try
            {
                int veri = Convert.ToInt32(Console.ReadLine());
                array[i] = veri;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());

            }
        }

        Array.Sort(array);
        Console.WriteLine("Array ortalamasi : " + array.Average());
        Console.WriteLine("En buyuk 3 sayi : " + array[^1] + " - " + array[^2] + " - " + array[^3]);
        Console.WriteLine("En kucuk 3 sayi : " + array[0] + " - " + array[1] + " - " + array[2]);
    }

    // 3. Islem
    public void UnluBul()
    {
        Console.WriteLine("--- Girilen cumledeki sesli harfleri bul ---\n");
        Console.WriteLine("Bir cumle giriniz : ");

        string? cumle = Console.ReadLine()?.ToLower();

        for (int i = 0; i < cumle?.Length; i++)
        {
            if (cumle[i] == 'a' || cumle[i] == 'e' || cumle[i] == 'i' || cumle[i] == 'o' || cumle[i] == 'u')
                Console.WriteLine(cumle[i]);
        }

    }
}




