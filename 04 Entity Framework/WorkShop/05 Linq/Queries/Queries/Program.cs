using System.Data.Entity;
using System.Linq;

namespace Queries
{
    public class CourseFlat
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var context = new AppDbContext();

            // Restrication
            //var query =
            //    from c in context.Courses
            //    where c.FullPrice > 10 && c.Level == 1
            //    orderby c.Level descending, c.Name
            //    //select new CourseFlat { Name = c.Name, Id = c.Id };
            //    select new { Name = c.Name, Id = c.Id };

            //foreach (var item in query)
            //{
            //    System.Console.WriteLine($"{item.Name} - {item.Id}");
            //}

            // Grouping
            //var groups =
            //    from c in context.Courses
            //    //where c.FullPrice > 10 && c.Level == 1
            //    orderby c.Name, c.Level descending
            //    group c by c.Level into g
            //    select g;

            //foreach (var group in groups)
            //{
            //    System.Console.WriteLine(group.Key);

            //    foreach (var courseItem in group)
            //    {
            //        System.Console.WriteLine($"\t {courseItem.Name}" );
            //    }
            //}

            // Inner Join
            //var query =
            //    from c in context.Courses
            //    join a in context.Authors on c.AuthorId equals a.Id
            //    select new { CourseName = c.Name, AuthorName = a.Name };

            // Grouping Join
            //var query =
            //    from a in context.Authors
            //    join c in context.Courses on a.Id equals c.AuthorId into g
            //    select new { AuthorName = a.Name, TotalCourse = g.Count() };

            //foreach (var author in query)
            //{
            //    System.Console.WriteLine($"{author.AuthorName} - {author.TotalCourse}");    
            //}

            // Cross Join
            //var query = 
            //    from c in context.Courses
            //    from a in context.Authors
            //select new { CourseName = c.Name, AuthorName = a.Name };

            //foreach (var courseItem in query)
            //{
            //    System.Console.WriteLine($"{courseItem.CourseName} - {courseItem.AuthorName}");
            //}




            //var course = context.Courses.Where(c => c.Id == 2).FirstOrDefault();
            //foreach (var tag in course.Tags)
            //{
            //    System.Console.WriteLine(tag.Name);
            //}


            //var result = context.Authors.ToList();
            //foreach (var item in result)
            //{
            //    var r = item.Courses.Count();
            //    item.Name = item.Name + " A1";
            //    context.SaveChanges();
            //}
            //result = result;


            //var courses = context.Courses
            //    .Where(c => c.Level == 1 )
            //    .OrderBy(c => c.Level)
            //    .ThenByDescending(c => c.Name);
            //var courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c => c.Level)
            //    .ThenByDescending(c => c.Name)
            //    .Select(c => new { Name = c.Name, AuthorName = c.Author.Name });
            var courses = context.Courses
               .Where(c => c.Level == 1)
               .OrderBy(c => c.Level)
               .ThenByDescending(c => c.Name)
              .Select(c => c.Tags).ToList();
            var tags = context.Courses
               .Where(c => c.Level == 1)
               .OrderBy(c => c.Level)
               .ThenByDescending(c => c.Name)
              .SelectMany(c => c.Tags).ToList();

            var groups = context.Courses.GroupBy(c => c.Level);

            var join = context.Courses.Join(context.Authors,
                c => c.AuthorId,
                a => a.Id,
                (course, author) => new { CourseName = course.Name, AuthorName = author.Name });
            var groupJoin = context.Authors.GroupJoin(context.Courses,
                a => a.Id,
                c => c.AuthorId,
                (author, course) => new { Courses = course.Count(), AuthorName = author.Name });

            var crossjoin = context.Authors.SelectMany(c => c.Courses,
                (author, course) => new { authorname = author.Name, coursename = course.Name });
            //Additional Methods
            //var page = context.Courses.Skip(2).Take(5);
            //var element = context.Courses.OrderBy(c => c.Level).FirstOrDefault(c => c.Level == 1);
            //var istrue = context.Courses.All(c => c.FullPrice > 10);
            //istrue = context.Courses.Any(c => c.Level == 1);
            //var count = context.Courses.Count();
            //var max = context.Courses.Max(c => c.FullPrice);
            //var course = context.Courses.Single(c => c.Name == "Name 2");
            //context.Courses.Remove(course);
            //context.SaveChanges();

            context.Dispose();
        }
    }
}
