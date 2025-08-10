Question: When I debug my linked list, the Next property shows the value of the next node (like Data: 20), not the memory address. How does it actually store the next node's location if I don't see the address?

Answer: In C#, the Next property in your Node class is of type Node?. This means each node holds a reference (not a raw memory address like in C or C++) to the next node object in the linked list. 

When you write something like head.Next = temp;, you are making head.Next point to the same node object as temp (which was the previous head). Internally, C# manages these references for you—think of them as "pointers" to objects, but you don't see the actual memory address.

When you debug and look at Next, you see the data of the next node because the debugger shows the object it references, not the actual memory address. The reference lets you access the next node's properties (like Data), allowing you to chain through the list.

Summary:
- Next stores a reference to another Node object
- You see the data in the debugger because it follows the reference and shows the node's contents
- C# hides the actual memory address, using object references instead for safety and simplicity