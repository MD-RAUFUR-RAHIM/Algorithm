// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] IndexMultiplicator(int[] a)
{
    int n = a.Length;
    int[] result = new int[n];
    for (int i = 0; i<n; i++)
    {
        int x = 1;
        for (int j = 0; j<n; j++)
        {    
            if (i == j)
                continue;
            x = x * a[j];
        }
        result[i] = x;
    }
    return result;
}
int[] x = new int[] {2,3,5};
x =IndexMultiplicator(x);
foreach(var i in x)
    Console.WriteLine(i);