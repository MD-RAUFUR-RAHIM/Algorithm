using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberInArray
{
    public class SmallAndBiggest
    {
        public int SmallestNumber(int[] arr)
        {
            int smallestIndex = 0; 
            int smallest = int.MaxValue;
            for(int i = 0; i< arr.Length;i++)
            {
                if (arr[i] < smallest)
                {
                    smallestIndex = i;
                    smallest = arr[i];
                }
            }
            return  smallestIndex ;
        }
        public int BiggestNumber(int[] arr)
        {
            int biggest = int.MinValue;
            foreach (var x in arr)
            {
                if (x > biggest)
                {
                    biggest = x;
                }
            }
            return biggest;
        }
    }
}
