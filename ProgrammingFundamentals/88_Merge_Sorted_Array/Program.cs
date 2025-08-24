int[] nums1 = {1,2,3,7,9,12,13,0,0};
int[] nums2 = {4,6,8};
Merge(nums1, 6, nums2, 3);
Console.WriteLine(string.Join(", ", nums1));  

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int p1 = m - 1;           
    int p2 = n - 1;           
    int p = m + n - 1;        

    while (p1 >= 0 && p2 >= 0)
    {
        if (nums1[p1] > nums2[p2])
        {
            nums1[p] = nums1[p1];
            p1--;
        }
        else
        {
            nums1[p] = nums2[p2];
            p2--;
        }
        p--;
    }

    
    while (p2 >= 0)
    {
        nums1[p] = nums2[p2];
        p2--;
        p--;
    }
}


