
Console.Write("Fibonacci serisi için derinlik giriniz: ");
int depth = Convert.ToInt32(Console.ReadLine());

if (depth <= 0)
    Console.WriteLine("Lütfen geçerli bir pozitif sayı giriniz.\n");
else
    Console.WriteLine($"Fibonacci serisinin ilk {depth} elemanının ortalaması: {Fibonacci.Avarage(depth)}");

Console.ReadKey();