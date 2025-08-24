int number = 59;
List<int> digitList = new List<int>();
while(number > 0)
{
    int x = (number % 10)* (number % 10);

    digitList.Add(x);
    number /= 10;
}

digitList.Reverse();
int[] digits = digitList.ToArray();
foreach(int digit in digits)
{
    Console.WriteLine(digit);
}