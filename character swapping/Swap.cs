
public class Swap
{
    public static string CharSwap(string cumle)
    {
        string[] swapped = cumle.Split(" ");
        for (int i = 0; i < swapped.Length; i++)
        {
            char x = swapped[i][0];
            swapped[i] = swapped[i].Remove(0, 1);
            swapped[i] = swapped[i] + x;
        }

        return string.Join(" ", swapped);
    }
}