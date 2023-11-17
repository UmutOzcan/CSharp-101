
Console.Write("Hesaplamak istedginiz problemi secin : (Alan , Cevre) -> ");
string? problem = Console.ReadLine();

switch (problem)
{
    case "Alan":
        Console.Write("\nAlanini hesaplamak istediginiz sekli secin : (Kare , Ucgen , Dikdortgen , Daire) -> ");
        string? shape = Console.ReadLine();
        Console.WriteLine("\n" + Shape.CalculateArea(shape));
        break;

    case "Cevre":
        Console.Write("\nCevresini hesaplamak istediginiz sekli secin : (Kare , Ucgen , Dikdortgen , Daire) -> ");
        string? shape2 = Console.ReadLine();
        Console.WriteLine("\n" + Shape.CalculatePerimeter(shape2));
        break;

    default:
        Console.WriteLine("\n\aGeçersiz giriş. Cevre ya da Alan yazınız.");
        break;
}

Console.ReadKey();