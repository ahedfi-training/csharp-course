using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 0, 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                if (number == 2)
                    continue;
                if (number == 3)
                    break;
                Console.WriteLine(number);
                // methods
            }


            var input = string.Empty;//input ="""";
            while (true)
            {
                Console.WriteLine("Enter :");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input : " + input);
                    continue;
                }
                break;
            }

            Console.WriteLine("End of program...");
        }
    }
}
