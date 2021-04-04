using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerScienceYA
{
  
    public class Queue<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public Queue()
        {
            this.head = null;
            this.tail = null;
        }
        public void Insert(T x)
        {
            Node<T> n = new Node<T>(x);

            if (this.IsEmpty())
                this.head = n;
            else
                this.tail.SetNext(n);
            this.tail = n;
        }
        public T Head()
        {
            return this.head.GetValue();
        }
        public T Remove()
        {
            T temp = this.head.GetValue();
            this.head = this.head.GetNext();
            return temp;
        }
        public bool IsEmpty()
        {
            return (this.head == null);
        }
        public override string ToString()
        {
            return this.head.ToString();
        }
    }
}
