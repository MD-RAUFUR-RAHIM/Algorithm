using System.Linq.Expressions;

 int[] ConstructRectangle(int area)
{  
    for(int i = (int)Math.Sqrt(area); i >= 1; i--)
    {
        if (area % i == 0)
        {
            int w = i;
            int l = area / i;
            return new int[] { l, w };
        }
    }
    return new int[] { area, 1 };
}


int x = 220;
var y = ConstructRectangle(x);
foreach (var x2 in y)
{
    Console.WriteLine(x2);
}