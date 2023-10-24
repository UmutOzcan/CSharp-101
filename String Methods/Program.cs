
string text = "Hi guys !!";
string text2 = "Hi";

// Length
Console.WriteLine("String uzunlugu => " + text.Length);

//ToUpper - ToLower
Console.WriteLine("String Uppercase =>" + text.ToUpper());
Console.WriteLine("String Lowercase =>" + text.ToLower());

//Concat
Console.WriteLine("Stringi Whats Up ! ile birlestir =>" + String.Concat(text, " Whats Up !"));

//Compare
Console.WriteLine("String text2 den uzun mu =>" + text.CompareTo(text2)); // text > text2 -> 1 | text < text2 -> -1 | text = text2 -> 0

//Contains
Console.WriteLine("String text2 icerir mi =>" + text.Contains(text2));
Console.WriteLine("String !! ile biter mi =>" + text.EndsWith("!!"));

//Index Of
Console.WriteLine("String guys kelimesini icerir mi =>" + text.IndexOf("guys"));

//Split
Console.WriteLine("String Splitin 1.elemani =>" + text.Split(" ")[0]);

Console.ReadKey();