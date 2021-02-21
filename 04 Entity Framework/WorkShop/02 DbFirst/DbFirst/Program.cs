using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermidate = 2,
        Advanced = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();

            course.Level = Level.Beginner;

            //using(var dbcontext = new LiveDemoEntities())
            //{
            //    var courses = dbcontext.GetCourses();
            //    foreach (var course in courses)
            //    {
            //        Console.WriteLine(course.Title);
            //    }
            //}
        }
    }
}
