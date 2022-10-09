using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; private set; }


        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new Node(element);
            }
            else
            {
                var newHead = new Node(element);
                newHead.Next = this.Head;
                this.Head.Previous = newHead;
                this.Head = newHead;
            }
            this.Count++;
        }
        public void AddLast(int element)
        {
            if (this.Count==0)
            {
                this.Tail = this.Head = new Node(element);
            }
            else
            {
                var newTail = new Node(element);
                newTail.Previous = this.Tail;
                this.Tail.Next = newTail;
                this.Tail = newTail;

            }
            this.Count++;

        }

        public int RemoveFirst()
        {
            if (this.Count==0)
            {
                throw new InvalidCastException("The list is empty");

            }
            var firstElement = this.Head.Value;
            this.Head = this.Head.Next;

            if (this.Head!=null)
            {
                this.Head.Previous = null;
            }
            else
            {
                this.Tail = null;
            }
            this.Count--;

            return firstElement;
        }

        public int RemoveLast()
        {
            var lastElement = this.Tail.Value;
            this.Tail = this.Tail.Previous;

            if (this.Tail!=null)
            {
                this.Tail.Next = null;
            }
            else
            {
                this.Head = null;
            }
            this.Count--;
            return lastElement;
        }

        public void ForEach(Action<int> action)
        {
            var currNode = this.Head;
            while (currNode!=null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int counter = 0;
            var currNode = this.Head;

            while (currNode!=null)
            {
                array[counter++] = currNode.Value;
                currNode = currNode.Next;

            }

            return array;
        }
    }



}
