namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.AppDbContext context)
        {

            context.Authors.AddOrUpdate(a => a.Id, new Author[]
            {
                new Author
                {
                    Id = 1,
                    Name = "John Smith2"
                },
                new Author
                {
                     Id = 2,
                    Name = "Bob Doe2"
                }
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
