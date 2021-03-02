using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.EntityConfigurations
{
    internal class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(t => t.Description)
                        .IsRequired()
                        .HasMaxLength(255);

          HasRequired(c => c.Author)
            .WithMany(c => c.Courses)
            .HasForeignKey(c => c.AuthorId)
            .WillCascadeOnDelete(false);

            HasMany(c => c.Tags)
                .WithMany(t => t.Courses)
                .Map(m =>
                {
                    m.ToTable("CourseTags");
                    m.MapLeftKey("CourseId");
                    m.MapRightKey("TagId");
                });
          
            HasRequired(c => c.Cover)
              .WithRequiredPrincipal(c => c.Course);
        }
    }
}
