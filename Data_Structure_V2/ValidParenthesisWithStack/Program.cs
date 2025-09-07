bool isValid(string s)
{
    Stack<char> chars = new Stack<char>();
    foreach(char c in s)
    {
        if (c == '{')
            chars.Push('}');
        else if (c == '[')
            chars.Push(']');
        else if (c == '(')
            chars.Push(')');
        else
        {
            if( chars.Count == 0 || chars.Pop() != c )
                return false;
        }
    }
    return chars.Count == 0;
}
Console.WriteLine(isValid("(){}[]"));