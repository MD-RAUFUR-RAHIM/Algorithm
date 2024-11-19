using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_3_Corman_Algo_Book_page_43
{

    internal class Program
    {
        public class Solution
        {
            public void LinearSearch(int[] A, int value)
            {
                bool key = false;
                int j = 0;
                for(int i=0; i<A.Length; i++)
                {
                    if(A[i] == value)
                    {
                        key = true;
                        j = i;
                    }
                }
                if (key)
                {
                    Console.WriteLine("The value is in " + j + "th index");
                }
                else 
                {
                    Console.WriteLine("The value does not exist");
                }
                
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 5, 4, 1, 3, 2 };
            Solution s = new Solution();
            s.LinearSearch(A, 2);
        }
    }
}
