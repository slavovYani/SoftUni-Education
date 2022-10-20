using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        public object Left { get; set; }
        public object Right { get; set; }

        public EqualityScale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public bool AreEqual()
        {
            if (Left==Right)
            {
                return true;
            }
            return false;
        }
    }
}
