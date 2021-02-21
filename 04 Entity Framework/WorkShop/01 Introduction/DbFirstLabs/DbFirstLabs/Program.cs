using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SampleDbFirstEntities())
            {
                var post = new Post()
                {
                    Body = "Body",
                    PublishedDate = DateTime.Now,
                    Title = "Title",
                    Id = 1
                };

                context.Posts.Add(post);
                context.SaveChanges();
            }
        }
    }
}
