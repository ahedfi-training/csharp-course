using CodeFirst.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=DefaultConnection")
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Cover> Covers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Moved To CourseConfiguration
            modelBuilder.Configurations.Add(new CourseConfiguration());

            //modelBuilder.Entity<Course>()
            //            .Property(t => t.Description) 
            //            .IsRequired()
            //            .HasMaxLength(255);

            //modelBuilder.Entity<Course>()
            //            .HasRequired(c => c.Author)
            //            .WithMany(c => c.Courses)
            //            .HasForeignKey(c => c.AuthorId)
            //            .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Course>()
            //            .HasMany(c => c.Tags)
            //            .WithMany(t => t.Courses)
            //            .Map(m => 
            //            { 
            //                m.ToTable("CourseTags");
            //                m.MapLeftKey("CourseId");
            //                m.MapRightKey("TagId");
            //            });

            ////modelBuilder.Entity<Author>()
            ////            .HasMany(c => c.Courses)
            ////            .WithRequired(c => c.Author)
            ////            .HasForeignKey(c => c.AuthorId);

            //modelBuilder.Entity<Course>()
            //            .HasRequired(c => c.Cover)
            //            .WithRequiredPrincipal(c => c.Course);


            base.OnModelCreating(modelBuilder);
        }
    }
}
