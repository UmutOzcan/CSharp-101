
public class RemoveAt
{
    public static string method(string kelime)
    {

        string[] clean = kelime.Split(",");
        int index = Convert.ToInt32(clean[1]);
        clean[0] = clean[0].Remove(index - 1, 1);


        return clean[0];
    }
}