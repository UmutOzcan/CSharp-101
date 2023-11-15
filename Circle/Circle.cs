
public class Circle
{
    public static void DrawCircle(int yaricap)
    {
        for (int derece = 0; derece < 360; derece++)
        {
            double radian = derece * Math.PI / 180.0;
            int x = (int)Math.Round(yaricap * Math.Cos(radian));
            int y = (int)Math.Round(yaricap * Math.Sin(radian));

            Console.SetCursorPosition(yaricap + x + 10, yaricap + y + 2);
            Console.Write('*');
            Thread.Sleep(10);
        }

        Console.SetCursorPosition(0, yaricap * 2 + 2); // Dairenin çiziminden sonra cursor'u alt satıra al
    }
}