
char[] dizi = "Merhaba".ConvertToChars();

foreach (var item in dizi)
{
    Console.WriteLine(item);
}

Console.ReadKey();

public static class Extensions
{
    public static char[] ConvertToChars(this string text)
    {
        char[] chars = new char[text.Length];
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = text[i];
        }
        return chars;
    }
}