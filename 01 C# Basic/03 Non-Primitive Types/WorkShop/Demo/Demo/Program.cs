using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // 11

            IncrementResult(number);
            //Console.WriteLine(result); 

            var person = new Person { Age = 20, salary = 900 };

            MakeOld(person);
            Console.WriteLine(person.Age); // 30

            //decimal salary = person; // implicit
            decimal salary = (decimal)person; // explicit

            int age = person;
        }

        public static void Increment(int value)
        {
            value += 10;
        }

        public static int IncrementResult(int value)
        {
            value += 10;
            return value;
        }
        public static void MakeOld(Person obj)
        {
            obj.Age += 10;
        }
    }
}
