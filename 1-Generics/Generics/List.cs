using System;

namespace Generics
{
    public class NumberList
    {
        public int[] Elements { get; set; }

        public void Add(int number)
        {
            Elements[Elements.Length + 1] = number; 
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}