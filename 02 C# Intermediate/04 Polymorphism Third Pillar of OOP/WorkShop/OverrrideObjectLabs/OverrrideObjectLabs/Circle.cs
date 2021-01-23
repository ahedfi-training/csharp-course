using System;

namespace OverrrideObjectLabs
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("I am Circle");
        }

        public void Display(string message, DateTime messageDate)
        {
            Console.WriteLine($"{message} {messageDate}");
        }
    }
}
