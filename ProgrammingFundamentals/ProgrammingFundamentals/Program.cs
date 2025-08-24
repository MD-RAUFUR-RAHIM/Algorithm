// See https://aka.ms/new-console-template for more information




using ProgrammingFundamentals;

void  MyMethodPassedByValue(int a)
{
    a += 2;
}
var b = 1;
MyMethodPassedByValue(b);
Console.WriteLine("Here b is remaining b = " + b +" as it is passed by value "); 

void MyMethodPassedByReference(ref int a)
{
    a += 2;
}
MyMethodPassedByReference(ref b);
Console.WriteLine("Here b is going to be  b = " + b + " as it is passed by Reference ");

