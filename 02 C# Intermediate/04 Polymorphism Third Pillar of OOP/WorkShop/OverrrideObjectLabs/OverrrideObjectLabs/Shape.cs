using System;

namespace OverrrideObjectLabs
{
    public class Shape
    {

        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        public virtual void Draw()
        {
            Console.WriteLine("I am shape");
        }
    }
}
