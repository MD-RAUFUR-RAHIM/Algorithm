using System.Runtime.CompilerServices;

Dictionary<int, string> rookieOfTheYear = new();
rookieOfTheYear.Add(2020, "Lewis Hamilton");
rookieOfTheYear.Add(2021, "Max Verstappen");
rookieOfTheYear.Add(2022, "George Russell");
rookieOfTheYear.Add(2023, "Oscar Piastri");
Console.WriteLine(rookieOfTheYear[2022]);

Dictionary<string, List<string>> wishList = new();
wishList.Add("Books", new List<string> { "C# in Depth", "Clean Code" });
wishList.Add("Movies", new List<string> { "Inception", "The Matrix" });
wishList.Add("Games", new List<string> { "The Witcher 3", "Dark Souls" });
foreach(var (key, value) in wishList)
{
    Console.WriteLine($"{key}:");
    foreach (var item in value)
    {
        Console.WriteLine($"- {item}");
    }
}