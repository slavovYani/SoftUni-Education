using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementList
{
    public class CustomList
    {
        private int[] items;
        public CustomList()
        {
            this.items = new int[initialCapacity];

        }



        private const int initialCapacity = 2;
        public int Count { get; private set; }
        public int this[int index]
        {

            get
            {
                if (index >= this.Count && index >= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {

                if (index >= this.Count && index >= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }
        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count++] = item;

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

        }
        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = this.items[index];
            this.items[index] = default(int);

            this.Shift(index);
            this.Count--;

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return result;

        }
        public bool Contains(int item)
        {
            foreach (var element in items)
            {
                if (element == item)
                {
                    return true;
                }
            }
            return false;
        }
        private void Resize()
        {
            int[] copy = new int[items.Length * 2];
            Array.Copy(items, 0, copy, 0, items.Length);
            items = copy;

        }
        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            Array.Copy(this.items, 0, copy, 0, copy.Length);
            //for (int i = 0; i < this.Count; i++)
            //{
            //    copy[i] = this.items[i];
            //}
            this.items = copy;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }

        }
        public void InsertAt(int index, int item)
        {
            if (index > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.items.Length == this.Count)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = item;
            this.Count++;
        }
        private void ShiftToRight(int index)
        {
            for (int i = Count; i >= index; i--)
            {
                this.items[i] = items[i - 1];
            }
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= this.Count && secondIndex >= this.Count)
            {

                throw new ArgumentOutOfRangeException();
            }
            int currItem = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = currItem;


        }
    }
}
