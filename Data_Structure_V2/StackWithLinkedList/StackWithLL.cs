using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithLinkedList
{
    public class StackWithLL
    {
       LinkedList<int> linkedList = new LinkedList<int>();
       public void Push(int val)
        {
            linkedList.AddFirst(val);
        }
        public int Pop() {
            int val = linkedList.First.Value;
            linkedList.RemoveFirst();
            return val;
        }
        public int Top()
        {
            if (linkedList.Count == 0)
                throw new InvalidOperationException("Stack is empty.");
            return linkedList.First.Value;
        }

        public bool IsEmpty()
        {
            return linkedList.Count == 0;
        }
    }
}
