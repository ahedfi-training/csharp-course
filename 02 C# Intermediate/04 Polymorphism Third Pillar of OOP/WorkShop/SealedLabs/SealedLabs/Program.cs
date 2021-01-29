using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedLabs
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public sealed class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am circle");
        }
    }

    public class CustomCircle : Circle
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
            var customCircle = new CustomCircle();
            customCircle.Draw();
        }
    }
}
