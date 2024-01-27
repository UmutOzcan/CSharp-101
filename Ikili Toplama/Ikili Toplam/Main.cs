
Console.WriteLine("Integer ikilileri girin (boşlukla ayırarak):");
string? input = Console.ReadLine();

List<int> result = Toplama.IkiliToplama(input);

Console.WriteLine("Toplamlar:");
foreach (int sum in result)
{
    Console.Write(sum + " ");
}

Console.ReadKey();