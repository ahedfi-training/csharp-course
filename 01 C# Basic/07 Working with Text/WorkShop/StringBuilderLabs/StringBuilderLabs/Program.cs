using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder(string.Empty);
            builder.Append("hello");
            builder.AppendLine(" hello");
            builder.AppendLine("just demo");
            builder.AppendLine("just demo2");
            builder.AppendLine("just demo3");
            builder.Append('-', 10);
            Console.WriteLine(builder.ToString());

            //var starString = string.Empty;
            //for (int i = 0; i < 1000; i++)
            //{
            //    starString += "*";
            //}


            var star = new StringBuilder("*");
            for (int i = 0; i < 1000; i++)
            {
                star.Append("*");
            }
            Console.WriteLine(star);
        }
    }
}
