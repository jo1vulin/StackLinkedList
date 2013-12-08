using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackUsingLinkedList;

namespace UnitTestStack
{
    [TestClass]
    public class Stack
    {
        /*
         * Push one element to empty Stack<T>,
         * verify that size of the list is now 1
         */ 
        [TestMethod]
        public void Push_One_Element_To_Empty_Stack()
        {
            //Arrange
            int stackSize = 1;
            Stack<int> newStack = new Stack<int>(); 

            //Act
            newStack.Push(1);

            //Assert
            Assert.AreEqual(stackSize, newStack.Count);
        }

        /*
         *Add one test element to Stack<T>, and verify that Peek()
         *will return added element
         */
        [TestMethod]
        public void Peek_On_Stack_With_One_Element()
        {
            //Arrange
            string elementInStack = "Test element";
            Stack<string> newStack = new Stack<string>();

            //Act
            newStack.Push(elementInStack);
            var topElementOfStack = newStack.Peek().elementValue;

            //Assert
            Assert.AreEqual(elementInStack, topElementOfStack);
        }

        /*
         * Add two elements to Stack<T> and verify that
         * the second added element is the top element
         */ 
        [TestMethod]
        public void Push_Two_Elements_To_Empty_Stack_Verify_That_Last_Added_Is_The_Top_Element_Of_Stack()
        {
            //Arrange
            string firstElementToAdd = "First added element";
            string secondElementToAdd = "Second added element";
            Stack<string> newStack = new Stack<string>();

            //Act
            newStack.Push(firstElementToAdd);
            newStack.Push(secondElementToAdd);
            var topElement = newStack.Peek().elementValue;


            //Assert
            Assert.AreEqual(secondElementToAdd, topElement);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException),"List is empty!")]
        public void Peek_On_Stack_With_No_Elements()
        {
            //Arrange
            Stack<string> newStack = new Stack<string>();

            //Act
            var topElementOfStack = newStack.Peek();

           
        }


    }
}
