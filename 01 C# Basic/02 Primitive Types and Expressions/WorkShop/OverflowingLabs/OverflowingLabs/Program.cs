using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 1.2f;
            double number2 = 1.2;
            decimal money = 1.2m;
            short length = 0;


            byte value = 255;
            int a = 275;
            value = (byte)275;
            Console.WriteLine(value);



            //try
            //{
            //    checked
            //    {
            //        byte value = 255;
            //        value += 2;
            //        Console.WriteLine(value);
            //    }
            //}
            //catch (Exception e)
            //{

            //    // handler execption
            //    Console.WriteLine("overflow occurs !!");
            //}

            //byte b = 1;
            //int a = b;

            //int a = 256;
            //byte b = (byte)a;

            string s = "abc";
            int i = Convert.ToInt32(s);
            int ii = int.Parse(s);

        }
    }
}
