
Solution1 s = new Solution1();
Console.WriteLine(s.IsPalindrome(101));
public class Solution1
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        int original = x;
        int reversed = 0;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return original == reversed;
    }
}
