using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    class Runner
    {
        public static void Main(string[] args)
        {
            IStack<int> newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            Console.WriteLine("ispis elemenata: ");
            newStack.writeAllElements();

            try
            {
               newStack.Pop();
               var pop = newStack.Pop();
               var peek = newStack.Peek();
               
                Console.WriteLine("Test pop: ");
                Console.WriteLine(pop.elementValue + " " + pop.previousElement.elementValue);
                Console.WriteLine("Test peek: ");
                    Console.WriteLine(peek.elementValue);
                
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine("Greska: " + exc.Message);
            }

            Console.WriteLine("Write all elements: ");
            newStack.writeAllElements();
            Console.ReadLine();

        }
    }
}
