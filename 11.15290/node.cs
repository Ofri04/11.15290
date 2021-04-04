using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceYA
{
    public class Node<T>
    {
        // תכונות
        private T value;
        private Node<T> next;

        // פעולה בונה מלאה
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        // פעולה בונה חלקית
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public override string ToString()
        {
            if (this.next == null)
                return "" + this.value;
            return this.value + " --> " + this.next;
        }
    }
   
}
