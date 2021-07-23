using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Stack
    {
        public static void StackDemo()
        {
            Stack<int> myStack = new Stack<int>();
            // Pushing into stack
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);

            //Count returns number of elements present in stack
            Console.Write("\nNumber of elements in Stack: {0}\n", myStack.Count);
            //returns true if element is present
            Console.WriteLine("{0} is ", myStack.Contains(1));
            while (myStack.Count > 0)
            {
                //Pop the element and print it
                Console.Write(myStack.Pop() + " ");
            }

            Console.Write("\nNumber of elements in Stack: {0}\n", myStack.Count);

        }
    }
}
