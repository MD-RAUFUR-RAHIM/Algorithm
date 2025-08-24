int[] x = new int[]
{
    1,2,1
};
int y;
int[] PlusOne(int[] digits)
{
    for(int i = digits.Length -1; i>=0; i--) 
    {
        if (digits[i] < 9)
        {
            digits[i]++;   
            return digits;
        }
        digits[i] = 0;
    }
    int[] newDigits = new int[digits.Length + 1];
    newDigits[0] = 1;
    return newDigits;
}