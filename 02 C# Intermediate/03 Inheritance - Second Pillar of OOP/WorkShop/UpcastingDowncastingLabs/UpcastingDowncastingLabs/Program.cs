using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Name = "Circle";
            circle.Diameter = 10;

            var subCircle = new SubCircle();
            subCircle.Name = "SubCircle";
            subCircle.Diameter = 20;
            subCircle.Position = 0;

            var shape = new Shape();
            shape.Name = "Shape";

            //Circle aCircle = shape; // Compile error

            // Circle aCircle = (Circle)shape; // Runtime error

            //Circle circleOne = shape as Circle; way 1
            if(shape is Circle)
            {
                Circle circleOne = (Circle)shape;
            }

            Shape aShape = subCircle;
            
            Circle aCircle = (Circle)aShape;
            SubCircle aSubCircle = (SubCircle)aShape;

            Square square = new Square();
            Shape shapeSquare = square;

            //Circle circleTwo = (Circle)shapeSquare;
            // TODO : Use AS or IS keyword to avoid downcast exception
        }
    }
}
