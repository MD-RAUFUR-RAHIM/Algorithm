using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaray_Sum
{
    public class BinaryAddition
    {
        public void Addition(int[] A, int[] B) 
        {
            int n=A.Length;
            int[] result = new int[n+1];
            int carry = 0;
            for (int i = n-1; i >= 0; i--)
            { 
                int sum = A[i] + B[i] + carry;
                result[i+1] = sum % 2;
                carry = sum / 2;
            }
            result[0] = carry;
            Console.WriteLine("Binary Addition Result: " + string.Join("", result));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 0, 1 };
            int[] B = { 1, 1, 1 };
            BinaryAddition binaryAddition = new BinaryAddition();
            binaryAddition.Addition(A, B);
        }
    }
}
