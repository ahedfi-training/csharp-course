using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            Console.WriteLine(course.Tags.Count);
        }
    }
}
