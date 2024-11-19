using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binaray_Sum_Different_Length
{
    public class BinaryAddition
    {
        public void Addition(int[] A, int[] B)
        {
            int n = A.Length;
            int m = B.Length;
            int maxLength = Math.Max(n, m);
            int[] paddedA = new int[maxLength];
            int[] paddedB = new int[maxLength];
            int[] result = new int[maxLength+1];
            int carry = 0;
            for (int i = 0; i < maxLength; i++)
            {
                if(i<n)
                     paddedA[maxLength - n + i] = A[i];
                if(i<m)
                    paddedB[maxLength - m + i] = B[i];
            }

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = paddedA[i] + paddedB[i] + carry;
                result[i+1] = sum % 2;
                carry = sum / 2;
            }
            result[0] = carry;
            //Console.WriteLine("Binary Addition Result: " + string.Join("", result));
            Console.WriteLine("Binary Addition Result: " + string.Join("", result));

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 0};
            int[] B = { 1, 1 };
            BinaryAddition binaryAddition = new BinaryAddition();
            binaryAddition.Addition(A, B);
        }
    }
}
