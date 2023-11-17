
public class Shape
{

    public static string CalculateArea(string shape)
    {
        switch (shape)
        {
            case "Ucgen":
                if (TryGetUserInput("Taban degerini giriniz:", out int taban) && TryGetUserInput("Yukseklik degerini giriniz:", out int h))
                    return $"Ucgenin alani = {taban * h / 2}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            case "Kare":
                if (TryGetUserInput("Kenar degerini giriniz:", out int kenar))
                    return $"Karenin alani = Math.Pow(kenar, 2)";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            case "Daire":
                if (TryGetUserInput("Yaricap degerini giriniz:", out int yaricap))
                    return $"Daire alani = {Math.PI * Math.Pow(yaricap, 2)}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            case "Dikdortgen":
                if (TryGetUserInput("Birinci kenar degerini giriniz:", out int kenar1) && TryGetUserInput("Ikinci kenar degerini giriniz:", out int kenar2))
                    return $"Dikdortgen alani = {kenar1 * kenar2}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            default:
                return "\aGeçersiz bir sekil girdiniz!";
        }
    }

    public static string CalculatePerimeter(string shape)
    {
        switch (shape)
        {
            case "Ucgen":
                if (TryGetUserInput("Birinci kenar degerini giriniz:", out int u1) && TryGetUserInput("Ikinci kenar degerini giriniz:", out int u2) && TryGetUserInput("Ucuncu kenar degerini giriniz:", out int u3))
                    return $"Ucgenin cevresi = {u1 + u2 + u3}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            case "Kare":
                if (TryGetUserInput("Kenar degerini giriniz:", out int kenar))
                    return $"Karenin cevresi = {kenar * 4}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            case "Daire":
                if (TryGetUserInput("Yaricap degerini giriniz:", out int yaricap))
                    return $"Daire cevresi = {Math.PI * yaricap * 2}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            case "Dikdortgen":
                if (TryGetUserInput("Birinci kenar degerini giriniz:", out int d1) && TryGetUserInput("Ikinci kenar degerini giriniz:", out int d2))
                    return $"Dikdortgen cevresi = {(d1 + d2) * 2}";
                else
                    return "\aGeçersiz giriş. Sayı giriniz.";

            default:
                return "\aGeçersiz bir sekil girdiniz!";
        }

    }

    private static bool TryGetUserInput(string prompt, out int result)
    {
        Console.Write("\n" + prompt);
        return int.TryParse(Console.ReadLine(), out result);
    }
}