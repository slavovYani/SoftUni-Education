﻿namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node Next { get; set; }

            public Node(T element, Node next)
            {
                Element = element;
                Next = next;
            }

            public Node(T element) : this(element, null) { }
        }

        private Node top;

        public int Count { get; private set; }

        public void Push(T item)
        {
            var node = new Node(item, this.top);
            this.top = node;
            this.Count++;
        }

        public T Pop()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException();
            }

            var oldTop = this.top;
            this.top = this.top.Next;
            this.Count--;

            return oldTop.Element;
        }

        public T Peek()
        {
            if (this.top == null)
            {
                throw new InvalidOperationException();
            }

            return this.top.Element;
        }

        public bool Contains(T item)
        {
            var node = this.top;

            for (int i = 0; i < Count; i++)
            {
                if (node.Element.Equals(item))
                {
                    return true;
                }

                node = this.top.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.top;

            while (node != null)
            {
                yield return node.Element;
                node = node.Next;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}