using System.Data.Entity;

namespace CodeFirstLab
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
