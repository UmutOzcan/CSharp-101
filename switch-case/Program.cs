
int month = DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayindasiniz !");
        break;

    case 2:
        Console.WriteLine("Subat ayindasiniz !");
        break;

    case 10:
        Console.WriteLine("Ekim ayindasiniz !");
        break;

    default:
        Console.WriteLine("Bosver kanka !");
        break;
}

Console.WriteLine("\n" + "-------------------------" + "\n");

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.Write("Kış mevsimindesiniz !");
        break;

    case 3:
    case 4:
    case 5:
        Console.Write("Bahar mevsimindesiniz !");
        break;

    case 6:
    case 7:
    case 8:
        Console.Write("Yaz mevsimindesiniz !");
        break;

    case 9:
    case 10:
    case 11:
        Console.Write("Güz mevsimindesiniz !");
        break;

    default:
        Console.WriteLine("Bosver kanka !");
        break;
}

Console.ReadKey();