string t = "Apple";
Dictionary<char, int> charCounts = new Dictionary<char, int>();
foreach (char c in t)
{
    if (charCounts.ContainsKey(c))
    {
        charCounts[c]++;
    }
    else
    {
        charCounts[c] = 1;
    }
}
foreach(var (key,value) in charCounts)
{
    Console.WriteLine($"Character: {key}, Count: {value}");
}