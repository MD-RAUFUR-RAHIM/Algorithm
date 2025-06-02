 int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0)
        return 0;
    int i = 0;
    for(int j= 1;  j<nums.Length; j++)
    {
        if (nums[j] != nums[i])
        {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1;
}

int[] x = new int[]
{
    0, 0, 1, 1, 2, 3, 3
};
int k = RemoveDuplicates(x);
Console.WriteLine(k);