using System;
namespace Structures
{
    public class Element<T>
    {
        public Element<T> next = null;
        public Element<T> before = null;
        public T value;

        public Element(T value)
        {
            this.value = value;
        }

    }

    public class MyList<T>
    {
        public Element<T> first = null;

        // TODO: Constructor with parameters like an array, etc.
        // public List() {

        // }
        public void Add(T value)
        {
            if (first != null)
            {
                Element<T> current = this.first;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Element<T>(value);
            }
            else
            {
                this.first = new Element<T>(value);
            }
        }

        public void ForEach()
        {
            Element<T> current = this.first;
            while (current != null)
            {
                Console.WriteLine("Value: " + current.value);
                current = current.next;
            }
        }

    }
}

