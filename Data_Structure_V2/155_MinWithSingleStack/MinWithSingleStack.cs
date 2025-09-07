using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155_MinWithSingleStack
{
    public class MinWithSingleStack
    {
        private Stack<long> stack;  // long use for safety from overflow
        private long minVal;

        public MinWithSingleStack()
        {
            stack = new Stack<long>();
        }

        public void Push(int val)
        {
            if (stack.Count == 0)
            {
                stack.Push(val);
                minVal = val;
            }
            else
            {
                if (val >= minVal)
                {
                    stack.Push(val);
                }
                else
                {
                    // encode value
                    stack.Push(2L * val - minVal);
                    minVal = val;
                }
            }
        }

        public void Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            long top = stack.Pop();
            if (top < minVal)
            {
                // retrieve previous min
                minVal = 2 * minVal - top;
            }
        }

        public int Top()
        {
            long top = stack.Peek();
            if (top >= minVal)
            {
                return (int)top;
            }
            else
            {
                return (int)minVal; // encoded case
            }
        }

        public int GetMin()
        {
            return (int)minVal;
        }
    }
}
