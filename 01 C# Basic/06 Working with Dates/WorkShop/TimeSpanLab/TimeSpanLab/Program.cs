using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);

            var timeSpan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration :" + duration);

            //Properties
            Console.WriteLine("Minutes :" + timeSpan.Minutes);
            Console.WriteLine("total Minutes :" + timeSpan.TotalMinutes);
           
            //Add
            Console.WriteLine("Add :" + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Substract :" + timeSpan.Subtract(TimeSpan.FromMinutes(10)));
            
            //ToString
            Console.WriteLine("ToString :" + timeSpan.ToString());

            var TimeSpanFromString = TimeSpan.Parse("01:02:03");
            //Parse
            Console.WriteLine("Parse :" + TimeSpan.Parse("01:02:03"));

        }
    }
}
