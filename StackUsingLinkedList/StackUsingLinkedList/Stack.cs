using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    public class Stack<T> : IStack<T>
    {
        #region class Elements

        /*
         * Stack<T> Elements
         */ 
        public class Elements
        {
            /*
             * Element saved in stack
             */
            public T elementValue;
            /*
             * Each elements has object of it's
             * previous element
             */
            public Elements previousElement;
        }

        #endregion

        /*
         * Propery Count with private set
         */
        public int Count { get; private set; }
        /*
         * topElement - in evry moment top element of stack is known
         */
        private Elements topElement;

        /*
         * InvalidOperationException error message constant
         */
        private const string LIST_EMPTY_ERROR_MESSAGE = "List is empty";


        /*
         * Push element to stack(Last in first out). Added element is the
         * top element of stack
         */
        public void Push(T elementToPushToStack)
        {
            Count++;
            if (topElement == null)
            {
                topElement = createElement(elementToPushToStack);
            }
            else
            {
                topElement = createElement(elementToPushToStack, topElement);
            }
            
        }

        /*
         * Pop - removes and returns the object at the top of the Stack<T>. 
         */
        public Elements Pop()
        {
            verifyIfListIsEmpty();
            Count--;
            var result = topElement;
            Elements tempElement = topElement.previousElement;
            topElement = tempElement;
            return result;
        }

        /*
         * Return top element of the Stack<T>
         */ 
        public Elements Peek()
        {
            verifyIfListIsEmpty();
            return topElement;
        }


        /*
         * Write all elements of Stack
         * Used only in testing
         * Remove from interface
         */ 
        public void writeAllElements()
        {
            Elements tempElement = topElement;

            while (tempElement != null)
            {
                Console.WriteLine(tempElement.elementValue);
                tempElement = tempElement.previousElement;
            }
        }

        /*
         * Checks if list is empty. Throws exception if list is empty
        */ 
        private void verifyIfListIsEmpty()
        {
            if (Count < 1)
            {
                throw new InvalidOperationException(LIST_EMPTY_ERROR_MESSAGE);
            }
        }

        /*
         * Create new element. previousElement is optional parameter in case that we are creating the
         * first element of Stack
         */ 
        private Elements createElement(T elementValue, Elements previousElement = null)
        {
            var newElement = new Elements()
            {
                elementValue = elementValue,
                previousElement=previousElement
            };
            return newElement;
        }
    }
}
