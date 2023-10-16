

Console.Write("Bir sayi girin ");
int sayac = int.Parse(Console.ReadLine());
int toplam = 0;
Console.WriteLine("1'den " + sayac + "'a kadar olan tek sayılar \n");
for (int i = 1; i <= sayac; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
        toplam += i;
    }

}
Console.WriteLine("\n1'den " + sayac + "'a kadar olan tek sayıların toplamı = " + toplam);

Console.WriteLine("\n------------------------------\n");

Console.Write("Bir sayi girin ");
int sayi = int.Parse(Console.ReadLine());
int sayac2 = 1;
int toplam2 = 0;
Console.WriteLine("1'den " + sayi + "'a kadar olan sayılar \n");
while (sayac2 <= sayi)
{
    Console.WriteLine(sayac2);

    toplam2 += sayac2;
    sayac2++;
}
Console.Write("\n1'den " + sayi + "'a kadar olan sayıların ortalaması = " + (toplam2 / sayi) + "\n");

Console.WriteLine("\n------------------------------\n");


string[] cars = { "Supra", "Camaro", "Mustang", "Competizione", "Charger" };
Console.WriteLine("En iyi arabalar : \n");
foreach (var car in cars)
{
    Console.WriteLine(car);
}
Console.Write("\n");

Console.ReadKey();