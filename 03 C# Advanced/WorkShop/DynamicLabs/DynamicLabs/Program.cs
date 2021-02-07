using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicLabs
{
    public class Foo
    {
        public string Bar { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = 0;
            value = "123";
            dynamic foo2 = new Foo();
            value = foo2.Start().Go().Stop();
            Console.WriteLine(value);
        }
    }
}
