using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Course
    {
        public Course()
        {
            Tags = new List<Tag>();
        }
        public int Id { get; set; }
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public CourseLevel Level { get; set; }
        public int AuthId { get; set; }

        [ForeignKey("AuthId")]
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
