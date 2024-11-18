using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSort
    {
        public void InsertionSort1(int[] A)
        {
            int key;
            int i;
            for (int j = 1; j < A.Length; j++)
            {
                key = A[j];
                i = j - 1;
                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
        }
            //foreach(var x in A)
            //{
            //    Console.Write("," +x);
            //}
            public void Print(int[] A) {
                bool first = true;
                foreach (var x in A)
                {
                    if (!first)
                    {
                        Console.Write(",");
                    }
                    Console.Write(x);
                    first = false; // After the first element, set `first` to false
                } 
            }
        
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 4, 1, 3, 2 };
            InsertionSort sort = new InsertionSort();
            sort.InsertionSort1(A);
            Console.Write("Sorted Array: [");
            sort.Print(A);
            Console.Write("]");
            
        }
    }

}