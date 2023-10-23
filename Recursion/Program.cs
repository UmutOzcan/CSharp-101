
Methods method = new();
method.EkranaYazdir("Us Alma Islemi : " + Convert.ToString(method.expo(2, 7)) + "\n" + "Fibonacci Serisi Bulma Islemi : " + Convert.ToString(method.FibonacciSerisi(7)));
Console.ReadKey();

class Methods
{
    public int expo(int sayi, int us)
    {
        if (us < 2)
        {
            return 1;
        }
        return expo(sayi, us - 1) * sayi;
    }

    public int FibonacciSerisi(int sayi)
    {
        if (sayi == 0)
            return 0;
        else if (sayi == 1)
            return 1;
        else
            return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

}