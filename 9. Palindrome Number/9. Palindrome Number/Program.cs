
Solution s = new Solution();
Console.WriteLine(s.IsPalindrome(101));
public class Solution()
{
    public bool IsPalindrome(int x)
    {
        string x1 = x.ToString();
        char[] x2 = x1.ToCharArray();
        string x3 = ReverseString(x2);
        if (x1 == x3)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public string ReverseString(char[] c) 
    {
        Array.Reverse(c);
        string reversedString = new string(c);
        return reversedString;
    }
}