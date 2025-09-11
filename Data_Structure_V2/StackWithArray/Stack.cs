using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArray
{
    public class Stack
    {
        int flag = 0;
        int[] arr = new int[10];

        // Push element
        public void Push(int val)
        {
            if (flag >= arr.Length)
                throw new InvalidOperationException("Stack overflow");
            arr[flag] = val;
            flag++;
        }

        // Pop element
        public int Pop()
        {
            if (flag == 0)
                throw new InvalidOperationException("Stack is empty");
            flag--;
            int val = arr[flag];
            arr[flag] = 0;  // optional
            return val;
        }

        // Peek top element
        public int Peek()
        {
            if (flag == 0)
                throw new InvalidOperationException("Stack is empty");
            return arr[flag - 1];
        }

        // Check if stack is empty
        public bool IsEmpty()
        {
            return flag == 0;
        }

        // Check if stack is full
        public bool IsFull()
        {
            return flag >= arr.Length;
        }
    }

}
