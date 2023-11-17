

try
{
    Console.Write("Sayi giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girilen sayi : " + sayi);

}
catch (Exception ex)
{
    Console.WriteLine("Hata : " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İslem tamamlandı.");
}

Console.WriteLine("\n" + "--------------------------------------------------------" + "\n");

try
{
    int a = int.Parse(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Hata : " + ex.Message.ToString());
}


Console.WriteLine("\n" + "--------------------------------------------------------" + "\n");

try
{
    int b = int.Parse("test");
}
catch (FormatException ex)
{
    Console.WriteLine("Hata : " + ex.Message.ToString());
}

Console.WriteLine("\n" + "--------------------------------------------------------" + "\n");

try
{
    int c = int.Parse("-20000000000000000000000");
}
catch (OverflowException ex)
{
    Console.WriteLine("Hata : " + ex.Message.ToString());
}

Console.ReadKey();