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
                int[] j = new int[A.Length];
                int count = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == value)
                    {
                        key = true;
                        j[count] = i;
                        count++;
                        // break;
                    }
                }
                //if (key)
                //{
                //    Console.WriteLine("The value is in " + j + "th index");
                //    Console.WriteLine("The value has " + count + " times in the array"); 
                //}
                if (key)
                {
                    Console.WriteLine("The value is found at the following indices:");
                    for (int i = 0; i < count; i++)
                    {
                        //if (i < count - 1)
                        //{
                        //    Console.Write(j[i] + ", ");
                        //}
                        //else
                        //{
                        //    Console.Write(j[i]);
                        //}

                        Console.Write(j[i] + (i < count - 1 ? ", " : "")); // Print indices
                    }
                    Console.WriteLine();
                    Console.WriteLine("The value appears " + count + " times in the array.");
                }
                else
                {
                    Console.WriteLine("The value does not exist");
                }

            }
            //public void LinearSearch(int[] A, int value)
            //{
            //    bool key = false;
            //    List<int> indices = new List<int>();
            //    int count = 0;

            //    for (int i = 0; i < A.Length; i++)
            //    {
            //        if (A[i] == value)
            //        {
            //            key = true;
            //            indices.Add(i); 
            //            count++;      
            //        }
            //    }

            //    if (key)
            //    {
            //        Console.WriteLine("The value is found at the following indices: " + string.Join(", ", indices));
            //        Console.WriteLine("The value appears " + count + " times in the array.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The value does not exist in the array.");
            //    }
            //}

        }
        static void Main(string[] args)
        {
            int[] A = { 5, 4, 5, 3, 2 };
            Solution s = new Solution();
            s.LinearSearch(A, 5);
        }
    }
}
