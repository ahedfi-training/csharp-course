using System;

namespace InheritanceLabs
{
    public class PersentationObject
    {
        public int Width;
        protected int Height;

        public void Copy()
        {
            Console.WriteLine("Item was copied !");
        }

        public void Duplicate()
        {
            Console.WriteLine("Item was duplicated !");
        }
    }
}
