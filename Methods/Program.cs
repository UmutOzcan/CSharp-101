
// erisimBelirteci geriDonusTipi methodAdi(parametreListesi)
// { komutlar 
//   return
// }

int a = 5;
int b = 3;
Console.WriteLine(a + b + "\n");

// method hali

Methods method = new();

method.EkranaYazdir("method.Topla cevabi = " + method.Topla(a, b));
method.EkranaYazdir("method.ArtirveTopla cevabi = " + method.Cikart(a, b));

Console.ReadKey();

class Methods
{
    public void EkranaYazdir(string value)
    {
        Console.WriteLine(value);
    }

    public int Topla(int value1, int value2)
    {
        return value1 + value2;
    }

    public int Cikart(int value1, int value2)
    {
        return value1 - value2;
    }
}









