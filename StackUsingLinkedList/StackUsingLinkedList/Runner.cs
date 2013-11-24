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
            Stack<int> newStack = new Stack<int>();
            newStack.addElement(1);
            newStack.addElement(2);
            newStack.addElement(3);
            newStack.addElement(4);
            newStack.addElement(5);
            newStack.addElement(6);

            Console.WriteLine("ispis elemenata: ");


            newStack.writeAllElements();

            try
            {
                newStack.removeElement();
                newStack.removeElement();
                newStack.removeElement();
                newStack.removeElement();
                newStack.removeElement();
                newStack.removeElement();
                newStack.removeElement();
                Console.WriteLine("Uklonjen poslednji element. Ispisi ponovo: ");
                newStack.writeAllElements();
            }
            catch(InvalidOperationException exc)
            {
                Console.WriteLine("Greska: " + exc.Message);
            }
            

            Console.ReadLine();

        }
    }
}
