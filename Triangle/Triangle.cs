
public class Triangle
{
    public static void DrawTriangle(int n)
    {
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }

}