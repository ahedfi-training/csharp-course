using System;

namespace GenericLabs
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public decimal Max(decimal a, decimal b)
        {
            return a > b ? a : b;
        }

        public T Max<T>(T a, T b) 
            where T : IComparable
        {
            return a.CompareTo(b) == -1 ? b : a;
        }
    }
}
