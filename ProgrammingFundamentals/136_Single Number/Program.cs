int[] x = new int[]
{
   4,4,2,2,5,5,9
};
// int SingleNumber(int[] nums)
//{
    
//    for (int i = 0; i < nums.Length; i++)
//    {
//        int temp = 0;
//        for (int j = 0; j < nums.Length; j++)
//        {
//            if (i != j && nums[i] == nums[j])
//            {
//                temp++;
//            }           
//        }
//        if (temp == 0)
//            return nums[i];
//    }
//    return -1;
//}
#region Using XOR
int SingleNumber2(int[] nums)
{
    int result = 0;
    foreach (int num in nums)
    {
        result ^= num;
    }
    return result;
}
#endregion

//int y = SingleNumber(x);
//Console.WriteLine(y);

int y = SingleNumber2(x);
Console.WriteLine(y);