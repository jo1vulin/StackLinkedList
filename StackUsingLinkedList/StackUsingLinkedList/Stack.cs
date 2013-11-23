using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    public class Stack<T>
    {
        //Clanovi stack-a
        public class Elements
        {
            //clan stack-a tipa T
            public T Element;
            //Svaki clan stack-a zna koji mu je prethodni clan(tipa Element) u nizu 
            public Elements Previous;
        }

        private int size;
        public int Count { get; private set; }
        private Elements firstElement;
        private Elements currentElement;

        //Dodaj novi clan
        //ako je prvi clan null onda dodeli vrednost ovog elmenta prvom clanu
        //ako nije prvi clan, dodaj ovom clanu Previous, trenutni element
        //na kraju trenutnom elementu dodeli vrednost novog elementa
        public void addElement(T elementForAdding)
        {
            size++;
            var newElement = new Elements()
            {
                Element = elementForAdding
            };

            if (firstElement == null)
            {
                firstElement = newElement;
            }
            else
            {
                newElement.Previous = currentElement;
            }
            currentElement = newElement;
        }

        //Ukloni poslednji element
        public void removeElement()
        {
            if (size < 1)
            {
                throw new InvalidOperationException("Lista je prazna");
            }
            else
            {
                size--;
                Elements tempElement = currentElement.Previous;
                currentElement = tempElement;
            }

        }


        //Test for adding elements to the list
        public void ListNodes()
        {
            Elements tempNode = currentElement;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Element);
                tempNode = tempNode.Previous;
            }
        }
    }
}
