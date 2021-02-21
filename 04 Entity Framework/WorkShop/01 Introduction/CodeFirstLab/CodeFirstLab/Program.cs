using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDbContext())
            {
                var post = new Post()
                {
                    Id = 1,
                    Title = "Title",
                    Body = "Body",
                    PublishedDate = DateTime.Now
                };

                context.Posts.Add(post);
                context.SaveChanges();
            }
        }
    }
}
