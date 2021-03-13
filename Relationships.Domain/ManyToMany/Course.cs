using System.Collections.Generic;

namespace Relationships.Domain.ManyToMany
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}