using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLabs
{
    public abstract class Vehicule
    {
        public abstract void Display();
    }
    public class Peugeot : Vehicule
    {
        public override void Display()
        {
            Console.WriteLine("I am Peugeot");
        }
    }

    public class BMW : Vehicule
    {
        public override void Display()
        {
            Console.WriteLine("I am BMW");
        }
    }

    public class Audi : Vehicule
    {
        public override void Display()
        {
            Console.WriteLine("I am Audi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var audi = new Audi();
            var peugeot = new Peugeot();
            var bmw = new BMW();
           // var vehicule = new Vehicule();
            var parking = new List<object>();

            // var vh = new Vehicule();

            parking.Add(audi); // upcasting
            parking.Add(peugeot);
            parking.Add(bmw);

            foreach (var obj in parking)
            {
                //Vehicule vehicule = obj as Vehicule;
                //if (vehicule != null)
                //{
                //    vehicule.Display();
                //}

                if (obj is Vehicule)
                {
                    Vehicule vehicule = (Vehicule)obj;
                    vehicule.Display();
                }
            }

            Vehicule v = DoSomething(audi);
            DoSomething(peugeot);
            DoSomething(bmw);

        }

        static Audi DoSomething(Vehicule vehicule)
        {
            //...
            return new Audi();
        }
    }
}
