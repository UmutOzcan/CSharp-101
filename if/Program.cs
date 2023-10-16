

int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
{
    Console.WriteLine("Günaydın !");
}
else if (time <= 18)
{
    Console.WriteLine("Iyi günler !");
}
else
{
    Console.WriteLine("Iyi geceler !");
}

Console.WriteLine("\n" + "------------ Another Way -------------" + "\n");

string sonuc = time >= 6 && time < 11 ? "Günaydın !" : time <= 18 ? "Iyi günler !" : "Iyi geceler!";
Console.WriteLine(sonuc);

Console.ReadKey();