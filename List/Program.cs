
List<int> nums = new()
{
    21,
    47,
    131,
    218,
    27,
    61,
    2
};

List<string> words = new List<string>();
words.Add("Selam");
words.Add("Hello");
words.Add("Salamu Aleykum");
words.Add("Halo");

Console.WriteLine("Nums List Count = " + nums.Count);
Console.WriteLine("Words List Count = " + words.Count);


// Foreach & List.Foreach
foreach (var num in nums)
    Console.WriteLine(num);

words.ForEach(word => Console.WriteLine(word));

// Remove
nums.Remove(27);
nums.RemoveAt(0);
nums.ForEach(num => Console.WriteLine(num));

// Contains
if (nums.Contains(131))
    Console.WriteLine("131 is in nums list. ");

// Array -> List
string[] animals = { "cat", "dog", "bird" };
List<string> animalsList = new(animals);
animalsList.ForEach(animal => Console.WriteLine(animal));


Console.ReadKey();