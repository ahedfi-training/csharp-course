using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var dbcontext = new LiveDemoEntities())
            {
                var courses = dbcontext.GetCourses();
                foreach (var course in courses)
                {
                    Console.WriteLine(course.Title);
                }
            }
        }
    }
}
