

public class Addition
{
    public static string method(string sayilar)
    {
        string[] sayilarArray = sayilar.Split(" ");
        int[] toplamlar = Array.Empty<int>();

        for (int i = 0, j = 0; i < sayilarArray.Length; i += 2, j++)
        {
            toplamlar[j] = Convert.ToInt32(sayilarArray[i]) + Convert.ToInt32(sayilarArray[i + 1]);
        }

        return sayilar;
    }
}