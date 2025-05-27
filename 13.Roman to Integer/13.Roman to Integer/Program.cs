List<char> roman = new List<char>();
Console.Write("s = ");
string input = Console.ReadLine();
roman.AddRange(input);
int x = roman.Count;
int result = 0;
for(int i = 0; i < x; i++)
{
    if (Check(roman[i]))
    {
        int currentValue = GetRomanIntValue(roman[i]);
       
        if(i< x - 1)
        {
            int nextValue = GetRomanIntValue(roman[i + 1]);

            if (currentValue < nextValue)
            {
                result = result - currentValue;
            }
            else
            {
                result = result + currentValue;
            }
        }
        else
        {
           
            currentValue = GetRomanIntValue(roman[i]);
            result = result + currentValue;
        }
    }
    

}
Console.WriteLine(result);
bool Check(char c)
{
  return c == 'I' || c == 'V' || c == 'X' || c == 'L' || c == 'C' || c == 'D' || c == 'M';
}
static int GetRomanIntValue(char c)
{
    switch (c)
    {
        case 'I':
            return 1;
        case 'V':
            return 5;
        case 'X':
            return 10;
        case 'L':
            return 50;
        case 'C':
            return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
        default:
            return 0;
    }
}
