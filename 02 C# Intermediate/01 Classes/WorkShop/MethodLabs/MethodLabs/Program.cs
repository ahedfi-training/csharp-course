using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLabs
{
    class Person
    {

    }
    partial class Program
    {
        static void Main(string[] args)
        {
            //var calc = new Calculator();
            //var result = calc.Add("calc is started", new int[] { 10, 20, 30 });
            //result = calc.Add("calc is started",1, 2, 3, 4, 5, 6, 7, 8, 10, 15, 30, 100,1000);
            //Console.WriteLine(result);


            int number = 1;
            Increment(ref number);
            Console.WriteLine(number);

            int outNumber;
            Set(out outNumber);
            Console.WriteLine(outNumber);

            string value = "123";
            int formatedNumber;

            var result = int.TryParse(value, out formatedNumber);
        }

        static void Increment(ref int a)
        {
            a += 2;
        }

        static void Set(out int number)
        {
            number = 10;
        }
    }
}
