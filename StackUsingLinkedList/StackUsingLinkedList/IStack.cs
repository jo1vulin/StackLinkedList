using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    interface IStack<T>
    {
        /*
         * Return the number of elements in Stack<T>
         */ 
        int Count { get; }

        /*
          * Push element to stack(Last in first out). Added element is the
          * top element of stack
          */
        void Push(T elementToPushToStack);

         /*
         * Pop - removes and returns the object at the top of the Stack<T>. 
         */
        Stack<T>.Elements Pop();

         /*
         * Return top element of the Stack<T>
         */
        Stack<T>.Elements Peek();


         /*
         * Write all elements of Stack
         * Used only in testing
         * Remove from interface
         */
        void writeAllElements();

        

    }
}
