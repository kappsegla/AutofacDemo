using System.Collections.Generic;

namespace AutofacDemo.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}