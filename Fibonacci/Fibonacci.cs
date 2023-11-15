
public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fib(n - 1) + Fib(n - 2);
    }

    public static double Avarage(int depth)
    {
        int[] fibonacci = new int[depth];
        double toplam = 0;

        for (int i = 0; i < depth; i++)
        {
            fibonacci[i] = Fib(i);
            toplam += fibonacci[i];
        }

        return toplam / depth;
    }
}