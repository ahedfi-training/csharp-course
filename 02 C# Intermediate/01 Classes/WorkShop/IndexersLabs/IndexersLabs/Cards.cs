using System.Collections.Generic;

namespace IndexersLabs
{
    public class Cards
    {
        private readonly List<int> _elements = new List<int>() { 1, 2, 3, 4 };

        public int this[int index]
        {
            get { return _elements[index]; }
            set { _elements[index] = value; }
        }
    }
}
