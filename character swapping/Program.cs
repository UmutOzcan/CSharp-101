
Console.Write("Istediginiz cumleyi girin :");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
    Console.WriteLine("Bir cumle giriniz !");
else
    Console.WriteLine(Swap.CharSwap(input));

Console.ReadKey();