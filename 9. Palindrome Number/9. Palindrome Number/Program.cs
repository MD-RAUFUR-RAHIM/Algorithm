
Solution s = new Solution();
Console.WriteLine(s.IsPalindrome(101));
public class Solution()
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        else
        {
            string x1 = x.ToString();
            char[] x2 = x1.ToCharArray();
            Array.Reverse(x2);
            return x1 == new string(x2);
        }
        

    }
    //public string ReverseString(char[] c) 
    //{
    //    Array.Reverse(c);
    //    string reversedString = new string(c);
    //    return reversedString;
    //}
}