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
            public T elementValue;
            //Svaki clan stack-a zna koji mu je prethodni clan(tipa Element) u nizu 
            public Elements previousElement;
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
                elementValue = elementForAdding
            };

            if (firstElement == null)
            {
                firstElement = newElement;
            }
            else
            {
                newElement.previousElement = currentElement;
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
                Elements tempElement = currentElement.previousElement;
                currentElement = tempElement;
            }

        }


        //Ispisi sve elmente
        public void writeAllElements()
        {
            Elements tempElement = currentElement;

            while (tempElement != null)
            {
                Console.WriteLine(tempElement.elementValue);
                tempElement = tempElement.previousElement;
            }
        }
    }
}
