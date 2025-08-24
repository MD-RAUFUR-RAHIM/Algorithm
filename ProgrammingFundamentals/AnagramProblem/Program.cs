bool IsAnagram(string s, string t)
{
    var length1 = s.Length;
    var length2 = t.Length;
    if (length1 != length2)
        return false;
    Dictionary<char, int> charCounts = new Dictionary<char, int>();
    foreach (char c in s)
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
    Dictionary<char, int> charCounts2 = new Dictionary<char, int>();
    foreach (char c in t)
    {
        if (charCounts2.ContainsKey(c))
        {
            charCounts2[c]++;
        }
        else
        {
            charCounts2[c] = 1;
        }
    }
    foreach (var (key, value) in charCounts)
    {
        if (!charCounts2.ContainsKey(key))
            return false;

        // Check if the counts match
        if (charCounts2[key] != value)
            return false;
    }
    return true;
}
//bool IsAnagram(string s, string t)
//{
//    if (s.Length != t.Length)
//        return false;
//    var counts = new Dictionary<char, int>();
//    for(int i = 0; i < s.Length; i++)
//    {
//        counts[s[i]] = counts.GetValueOrDefault(s[i], 0) + 1;
//        counts[t[i]] = counts.GetValueOrDefault(t[i], 0) - 1;
//    }
//    foreach(var count in counts.Values)
//    {
//        if(count != 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}
string s = "elppa";
string t = "apple";
bool result = IsAnagram(s, t);
Console.WriteLine(result);
