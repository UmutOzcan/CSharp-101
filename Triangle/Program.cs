
Console.Write("Üçgenin boyutunu giriniz: ");
int boyut = Convert.ToInt32(Console.ReadLine());

if (boyut <= 0)
{
    Console.WriteLine("Lütfen geçerli bir pozitif sayı giriniz.\n");
}
else
{
    Triangle.DrawTriangle(boyut);
}

Console.ReadKey();