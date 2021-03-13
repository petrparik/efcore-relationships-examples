using System.Collections.Generic;

namespace Relationships.Domain.ManyToMany
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}