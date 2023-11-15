
Console.WriteLine("Kelimeyi ve içinden çıkarmak istediğiniz harfin sırasını yazınız. ( kelime,index )");
string? kelime = Console.ReadLine();
if (string.IsNullOrEmpty(kelime) || !kelime.Contains(','))
    Console.WriteLine("Doğru formatta giriş yapınız. (kelime, index)");
else
    Console.WriteLine(RemoveAt.method(kelime));

Console.ReadKey();