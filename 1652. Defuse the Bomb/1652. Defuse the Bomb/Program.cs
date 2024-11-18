using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1652.Defuse_the_Bomb
{

    public class BombDufuse{

        public void Solution(int[] A, int key)
        {
            int n = A.Length;
            int[] result = new int[n];
            if (key > 0)
            {
                int temp=0;
                for (int i = 0; i < n; i++)
                {
                    for(int j = 1; j <= key; j++)
                    {
                        temp = temp + A[(i+j)%n];
                    }
                    result[i] = temp;
                    temp = 0;
                }   
            }
            if(key < 0)
            {
                int temp = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= Math.Abs(key); j++)
                    {
                        temp = temp + A[(i - j+n) % n];
                    }
                    result[i] = temp;
                    temp = 0;
                }
            }
            if (key == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result[i] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                A[i] = result[i];
            }
        }
     }


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 2, 4, 9, 3 };
            int k = -2;
            BombDufuse b = new BombDufuse();
            b.Solution(A, k);
            foreach (int i in A) 
            { 
            Console.Write(i+",");
            }
        }
    }
}
