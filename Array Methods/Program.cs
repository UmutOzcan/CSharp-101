int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

Console.WriteLine("*** Sirasiz Dizi ***");
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Sort
Console.WriteLine("\n*** Sirali Dizi ***");
Array.Sort(sayiDizisi);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Clear
Console.WriteLine("\n** Array Clear **");
// sayiDizisi elemanlarini kullanarak 2.index ten itibaren 3 tane elemani 0'lar.
Array.Clear(sayiDizisi, 2, 3);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Reverse
Console.WriteLine("\n** Array Reverse **");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//Index0f
Console.WriteLine("\n** Array IndexOf **");
Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

//Resize
Console.WriteLine("\n** Array Resize **");
Array.Resize<int>(ref sayiDizisi, 10);
sayiDizisi[8] = 33;
//sayiDizisi[9] = 66;
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);


Console.ReadKey();