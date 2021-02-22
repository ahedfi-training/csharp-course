using System.Collections.Generic;

namespace CodeFirst
{
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
