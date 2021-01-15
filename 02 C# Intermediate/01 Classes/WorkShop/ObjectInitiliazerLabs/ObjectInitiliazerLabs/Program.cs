using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitiliazerLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1)
            {
                FirstName = "Cooper",
                LastName = "John",
                BirthDate = new DateTime(1990, 1, 1)
            };
            Console.WriteLine(person.FirstName);
        }
    }
}
